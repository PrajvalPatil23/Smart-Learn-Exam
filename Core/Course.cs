using Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CourseTbl")]
    public class Course
    {
        [Key]
        public Int64 CourseID { get; set; }

        [Required(ErrorMessage = "Course Name is required")]
        [StringLength(200)]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Course Description is required")]
        [StringLength(500)]
        public string CourseDescription { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration should be greater than 0")]
        public int Duration { get; set; }

        public DurationEnum DurationEnum { get; set; }

        [Required(ErrorMessage = "Course Category is required")]
        [ForeignKey("CourseCategory")]
        public Int64 CourseCategoryID { get; set; }

        public string CourseLogo { get; set; }

        [NotMapped]
        public IFormFile PhotoFile { get; set; }

        public virtual CourseCategory CourseCategory { get; set; }
    }


}
