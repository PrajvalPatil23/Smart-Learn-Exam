using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface ICourseSubjectRepo : IGenericRepo<CourseSubject>
    {
        public List<CourseSubject> GetSubjectsForCourse(long courseId);

        public void UpdateCourseSubjects(long courseId, long[] selectedSubjectIds);

    }
}
