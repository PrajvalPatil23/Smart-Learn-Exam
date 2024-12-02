using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;
using Microsoft.AspNetCore.Http;

namespace Infra.ViewModels
{
    public class StudentVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }
        public GenderEnum Gender{ get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
       
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ProfilePicture {  get; set; }
        public bool IsActive {  get; set; }
        public IFormFile PhotoFile { get; set; }
    }
}
