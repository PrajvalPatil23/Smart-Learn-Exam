using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface IQuestionOptionRepo : IGenericRepo<QuestionOptions>
    {
        void AddOption(QuestionOptions rec, Int64 id);
        List<QuestionOptions> GetOptionsByQuestionID(Int64 questionID);
        void UpdateOption(QuestionOptions option);
        void SetCorrectOption(long questionID, long selectedOptionID);
    }
}
