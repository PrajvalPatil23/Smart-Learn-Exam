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
    public class CourseSubjectRepo : GenericRepo<CourseSubject>, ICourseSubjectRepo
    {
         Context cc;

        public CourseSubjectRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<CourseSubject> GetSubjectsForCourse(long courseId)
        {
            return cc.CourseSubjects
                           .Include(cs => cs.Subject) // Eager load the Subject
                           .Where(cs => cs.CourseID == courseId)
                           .ToList();
        }

        public void UpdateCourseSubjects(long courseId, long[] selectedSubjectIds)
        {
            // Get all existing subjects for the course
            var existingSubjects = cc.CourseSubjects
                                           .Where(cs => cs.CourseID == courseId)
                                           .ToList();

            // Find subjects to remove (those that are in the database but not in the selected list)
            var subjectsToRemove = existingSubjects.Where(cs => !selectedSubjectIds.Contains(cs.SubjectID)).ToList();
            cc.CourseSubjects.RemoveRange(subjectsToRemove);

            // Find subjects to add (those that are in the selected list but not in the database)
            var subjectsToAdd = selectedSubjectIds
                .Where(subjectId => !existingSubjects.Any(cs => cs.SubjectID == subjectId))
                .Select(subjectId => new CourseSubject
                {
                    CourseID = courseId,
                    SubjectID = subjectId,
                    AddedDate = DateTime.Now
                })
                .ToList();

            cc.CourseSubjects.AddRange(subjectsToAdd);

            // Save changes
            cc.SaveChanges();
        }

      
    }

}

