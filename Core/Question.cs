using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("QuestionTbl")]
    public class Question
    {
        [Key]
        public Int64 QuestionID {  get; set; }
        public string QuestionTitle {  get; set; }
        public string QuestionDescription { get; set; }
        [ForeignKey("Topic")]
        public Int64 TopicID {  get; set; }
        public QuestionTypeEnum QuestionType { get; set; }
        public string FilePath {  get; set; }
        public virtual  Topic Topic { get; set; }

        public virtual List<QuestionOptions>QuestionOptions { get; set; }

    }
}
