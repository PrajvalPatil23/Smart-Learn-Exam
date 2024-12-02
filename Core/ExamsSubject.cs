using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ExamsSubjectTbl")]
    public class ExamsSubject
    {
        [Key]
        public Int64 ExamsSubjectID { get; set; }
        [ForeignKey("Subject")]
        public Int64 SubjectID {  get; set; }
        [ForeignKey("CourseExam")]
        public Int64 CourseExamID {  get; set; }
        public int SubjectPercentage {  get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Exams Exams { get; set; }
    }
}
