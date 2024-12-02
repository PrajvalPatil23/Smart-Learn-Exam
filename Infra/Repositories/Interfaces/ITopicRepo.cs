using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface ITopicRepo:IGenericRepo<Topic>
    {
       
        List<TopicVM> GetTopicsBySubject(long subjectId);
    }
}
