using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class QuestionCreateVM
    {
        public string QuestionTitle { get; set; }

        public string QuestionDescription { get; set; }

        public Int64 TopicID { get; set; }

        public QuestionTypeEnum QuestionType { get; set; }

        public string FilePath { get; set; }

        public List<QuestionOptionVM> Options { get; set; } = new List<QuestionOptionVM>();
    }
}
