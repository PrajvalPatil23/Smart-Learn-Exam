using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface IQuestionRepo : IGenericRepo<Question>
    {
        void CreateQuestionWithOptions(QuestionCreateVM model);
        List<QuestionVM> GetQuestionByTopic(Int64 topicid);
        void DeleteQuestion(long questionId);
    }
}
