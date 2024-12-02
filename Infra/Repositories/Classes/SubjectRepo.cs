using Core;
using Infra.Repositories.Interfaces;
using Infra.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class SubjectRepo : GenericRepo<Subject>, ISubjectRepo
    {
        Context cc;

        public SubjectRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<SubjectVM> GetAllSubjectsWithTopicCount()
        {
            var result = from subject in cc.Subjects
                         join topic in cc.Topics on subject.SubjectID equals topic.SubjectID into topicGroup
                         select new SubjectVM
                         {
                             SubjectID = subject.SubjectID,
                             SubjectName = subject.SubjectName,
                             TopicCount = topicGroup.Count() 
                         };

            return result.ToList();
        }

        public Int64[] GetSubjectIdsByCourseId(int courseId)
        {
            // Assuming CourseSubject is the junction table linking courses and subjects
            return cc.CourseSubjects
                           .Where(cs => cs.CourseID == courseId)
                           .Select(cs => cs.SubjectID)
                           .ToArray();
        }

    }
}
