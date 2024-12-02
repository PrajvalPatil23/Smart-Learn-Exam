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
    [Table("ExamsTbl")]
    public class Exams
    {
        [Key]
        public Int64 CourseExamID {  get; set; }
        public string ExamTitle {  get; set; }
        public int NoOfQuestions {  get; set; }

        public QuestionTypeEnum QuestionTypes { get; set; }
        public int MarksPerQuestion {  get; set; }
        public bool IsNegativeMarking {  get; set; }

        public decimal PassingPercentile {  get; set; }

    }
}
