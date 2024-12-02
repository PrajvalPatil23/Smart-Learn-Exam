using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class ManageQuestionVM
    {
        public long TopicID { get; set; }
        public string TopicName { get; set; }
        public string SubjectName { get; set; }
        public List<Question> Questions { get; set; }
    }

}
