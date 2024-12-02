using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface ICourseRepo:IGenericRepo<Course>
    {
        void AddCourseWithSubjects(Course course, Int64[] subjectIds);
        void DeleteCourseAndSubjects(Int64 courseId);

        IEnumerable<CourseSubject> GetCourseSubjects(Int64 courseId);

        Course GetCourseById(long id);
        void UpdateCourseWithSubjects(Course rec, long[] chk);
    }
}
