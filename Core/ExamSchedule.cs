using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ExamScheduleTbl")]
    public class ExamSchedule
    {
        [Key]
        public Int64 ExamScheduleID {  get; set; }
        [ForeignKey("Student")]
        public Int64 StudentID {  get; set; }

        public DateTime StartDateTime { get; set; }
        [ForeignKey("Exams")]
        public Int64 ExamID {  get; set; }
        public string Note { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exams Exams { get; set; }
    }
}
