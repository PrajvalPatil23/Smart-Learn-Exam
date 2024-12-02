using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CourseSubjectTbl")]
    public class CourseSubject
    {
        [Key]
        public Int64 CourseSubjectID { get; set; }

        [ForeignKey("Subject")]
        public Int64 SubjectID { get; set; }

        public virtual Subject Subject { get; set; }

        public Int64 CourseID { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }
    }

}
