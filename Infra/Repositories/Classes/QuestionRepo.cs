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
    public class QuestionRepo : GenericRepo<Question>, IQuestionRepo
    {
        Context cc;
        public QuestionRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
        public void CreateQuestionWithOptions(QuestionCreateVM model)
        {
            var question = new Question
            {
                QuestionTitle = model.QuestionTitle,
                QuestionDescription = model.QuestionDescription,
                TopicID = model.TopicID,
                QuestionType = model.QuestionType,
                FilePath = model.FilePath
            };

            cc.Questions.Add(question);
            cc.SaveChanges();

            foreach (var option in model.Options)
            {
                var questionOption = new QuestionOptions
                {
                    QuestionID = question.QuestionID,
                    Option = option.OptionText,
                    IsCorrect = option.IsCorrect
                };

                cc.QuestionOptions.Add(questionOption);
            }

            cc.SaveChanges();
        }
        public List<QuestionVM> GetQuestionByTopic(long TopicID)
        {
            var res = this.cc.Questions
                .Where(p => p.TopicID == TopicID)
                .Select(q => new QuestionVM
                {
                    QuestionID = q.QuestionID,
                    QuestionTitle = q.QuestionTitle,
                    QuestionDescription = q.QuestionDescription,
                    TopicID = q.TopicID,
                    TopicName = q.Topic.TopicName // Assuming navigation property exists
                }).ToList();

            return res;
        }


        public void DeleteQuestion(long questionId)
        {
            var res = this.cc.Questions.
                    Include(p => p.QuestionOptions).
                    FirstOrDefault(p => p.QuestionID == questionId);

            if (res != null)
            {
                foreach (var temp in res.QuestionOptions.ToList())
                {
                    this.cc.QuestionOptions.Remove(temp);
                }
            }

            this.cc.Questions.Remove(res);
            this.cc.SaveChanges();
        }
    }
}

