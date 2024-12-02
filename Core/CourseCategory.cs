using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CourseCategory")]
    public class CourseCategory
    {
        [Key]
        public Int64 CourseCategoryID { get; set; }

        [Required(ErrorMessage = "Course Category Name is required")]
        [StringLength(200)]
        public string CourseCategoryName { get; set; }
    }

}
