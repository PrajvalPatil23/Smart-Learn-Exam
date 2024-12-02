using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StudentCourse")]
    public class StudentCourse
    {
        [Key]
        public Int64 StudentCourseID { get; set; }
        [ForeignKey("Student")]
        public Int64 StudentID {  get; set; }
        [ForeignKey("Course")]
        public Int64 CourseID {  get; set; }
        public DateTime AssignedDate {  get; set; }
        public virtual Course Course { get; set; }
        public virtual Student  Student { get; set; }
    }
}
