using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("QuestionOptionsTbl")]
    public class QuestionOptions
    {
        [Key]
        public Int64 QuestionOptionsID {  get; set; }
        [ForeignKey("Question")]

        public Int64 QuestionID { get; set; }
        public string Option {  get; set; }
        public bool IsCorrect {  get; set; }

        public virtual Question Question { get; set; }
    }
}
