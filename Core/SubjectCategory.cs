using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SubjectCategory")]
    public class SubjectCategory
    {
        [Key]
        public Int64 SubjectCategoryID {  get; set; }
        [Required(ErrorMessage = "Subject Category Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Subject Category Name should be between 3 and 100 characters.")]
        public string SubjectCategoryName { get; set; }

    }
}
