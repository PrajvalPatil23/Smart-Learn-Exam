using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ExamsResult")]
    public class ExamsResult
    {
        [Key]
        public Int64 ExamResult {  get; set; }
        [ForeignKey("Student")]
        public Int64 StudentID {  get; set; }
        public DateTime ExamDate { get; set; }
        [ForeignKey("CourseExam")]
        public Int64 CourseExamID {  get; set; }
        public int TotalMarks { get; set; }
        public int NegativeMarks {  get; set; }
        public int ObtainedMarks {  get; set; }
        public int FinalMarks {  get; set; }
        public virtual Student Student { get; set; }
        public virtual Exams Exams { get; set; }

    }
}
