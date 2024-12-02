using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SubjectTbl")]
    public class Subject
    {
        [Key]
        public Int64 SubjectID { get; set; }

        [Required(ErrorMessage = "Subject Name is required")]
        [StringLength(200)]
        public string SubjectName { get; set; }

        [StringLength(300, MinimumLength = 10, ErrorMessage = "Subject Description should be between 10 and 300 characters.")]
        public string SubjectDescription { get; set; }
    }

}
