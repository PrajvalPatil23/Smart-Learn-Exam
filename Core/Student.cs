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
    [Table("Student")]
    public class Student
    {
        [Key]
        public Int64 StudentID {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }
        public GenderEnum Gender { get; set; }
        public string EmailID {  get; set; }
        public string MobileNo {  get; set; }
        public string Password {  get; set; }
        public bool IsActive {  get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string ProfilePicture { get; set; }

    }
}
