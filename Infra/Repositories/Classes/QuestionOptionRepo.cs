using Core;
using Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class QuestionOptionRepo:GenericRepo<QuestionOptions>,IQuestionOptionRepo
    {
        Context cc;

        public QuestionOptionRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
        public void AddOption(QuestionOptions rec, long id)
        {
            throw new NotImplementedException();
        }

        public List<QuestionOptions> GetOptionsByQuestionID(long questionID)
        {
            return this.cc.QuestionOptions.Where(p => p.QuestionID == questionID).ToList();
        }


        public void UpdateOption(QuestionOptions option)
        {
            var existingOption = this.cc.QuestionOptions.Find(option.QuestionOptionsID);
            if (existingOption != null)
            {
                existingOption.IsCorrect = option.IsCorrect;
                this.cc.SaveChanges();
            }
        }

        public void SetCorrectOption(long questionID, long selectedOptionID)
        {
            var options = this.cc.QuestionOptions.Where(o => o.QuestionID == questionID).ToList();

            foreach (var option in options)
            {
                option.IsCorrect = false;
            }

            var selectedOption = options.FirstOrDefault(o => o.QuestionOptionsID == selectedOptionID);
            if (selectedOption != null)
            {
                selectedOption.IsCorrect = true;
            }


            this.cc.SaveChanges();
        }
    }
}
