using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface ISubjectRepo : IGenericRepo<Subject>
    {
       
            List<SubjectVM> GetAllSubjectsWithTopicCount();

        Int64[] GetSubjectIdsByCourseId(int courseId);



    }
}
