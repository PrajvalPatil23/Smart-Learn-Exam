using Core;
using Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class CourseRepo : GenericRepo<Course>, ICourseRepo
    {
        Context cc;
        public CourseRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
        public void AddCourseWithSubjects(Course course, Int64[] subjectIds)
        {
            Add(course);
            foreach (var subjectId in subjectIds)
            {
                var res = new CourseSubject
                {
                    CourseID = course.CourseID,
                    SubjectID = subjectId,
                    AddedDate = DateTime.Now
                };
                cc.CourseSubjects.Add(res);
            }
            cc.SaveChanges();
        }
        public void DeleteCourseAndSubjects(Int64 courseId)
        {
            var course = GetByID(courseId);
            if (course != null)
            {
                var res = cc.CourseSubjects.Where(cs => cs.CourseID == courseId).ToList();
                cc.CourseSubjects.RemoveRange(res);
                Delete(courseId);
            }


        }
        public IEnumerable<CourseSubject> GetCourseSubjects(Int64 courseId)
        {
            return cc.CourseSubjects.Where(cs => cs.CourseID == courseId).ToList();
        }
        public Course GetCourseById(long id)
        {
            return cc.Courses.FirstOrDefault(c => c.CourseID == id);
        }
        public void UpdateCourseWithSubjects(Course course, Int64[] selectedSubjectIds)
        {
            // Fetch the current state of the course from the database
            var existingCourse = cc.Courses
                                   .FirstOrDefault(c => c.CourseID == course.CourseID);

            // Ensure that the course exists
            if (existingCourse == null)
            {
                throw new Exception("The specified course does not exist.");
            }

            // Check if the course properties have actually changed
            bool courseChanged = existingCourse.CourseName != course.CourseName ||
                                 existingCourse.CourseCategoryID != course.CourseCategoryID ||
                                 existingCourse.CourseLogo != course.CourseLogo;

            if (courseChanged)
            {
                // Update course details only if something has changed
                existingCourse.CourseName = course.CourseName;
                existingCourse.CourseCategoryID = course.CourseCategoryID;
                existingCourse.CourseLogo = course.CourseLogo;

                // Update the course in the context
                cc.Courses.Update(existingCourse);
            }

            // Get current subjects associated with the course from CourseSubjectTbl
            var currentSubjects = cc.CourseSubjects
                                    .Where(cs => cs.CourseID == course.CourseID)
                                    .ToList();

            // Compare current subjects with selected subjects
            bool subjectsChanged = currentSubjects.Select(cs => cs.SubjectID).OrderBy(id => id)
                                                  .SequenceEqual(selectedSubjectIds.OrderBy(id => id)) == false;

            if (subjectsChanged)
            {
                // Remove old subject associations that are no longer selected
                var subjectsToRemove = currentSubjects
                                       .Where(cs => !selectedSubjectIds.Contains(cs.SubjectID))
                                       .ToList();

                foreach (var subjectToRemove in subjectsToRemove)
                {
                    cc.CourseSubjects.Remove(subjectToRemove);
                }

                // Add new subject associations that were selected but not currently associated
                var newSubjectsToAdd = selectedSubjectIds
                                       .Where(subjectId => !currentSubjects.Any(cs => cs.SubjectID == subjectId))
                                       .ToList();

                foreach (var subjectId in newSubjectsToAdd)
                {
                    cc.CourseSubjects.Add(new CourseSubject
                    {
                        CourseID = course.CourseID,
                        SubjectID = subjectId,
                        AddedDate = DateTime.Now // Set the added date
                    });
                }
            }

            // Only save changes if something has changed (course or subjects)
            if (courseChanged || subjectsChanged)
            {
                cc.SaveChanges();
            }
        }



    }
}
