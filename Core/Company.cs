using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CompanyTbl")]
    public class Company
    {
        [Key]
       public Int64 CompanyID { get; set; }
        [Required]
        public string CompanyName { get; set; } 
        [Required]
        public string Address { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Enter Valid EmailID")]
        public string EmailID {  get; set; }
        [Required]
        [RegularExpression( @"\^[0-9]{10}$")]
        public string MobileNo {  get; set; }
        public string LogoPath {  get; set; }
        public DateTime RegistrationDate { get; set; }
        [ForeignKey("City")]
        public Int64 CityID {  get; set; }
        public virtual City City { get; set; }
        public string WebsiteUrl { get; set; }  
        public string ContactPersonName {  get; set; }






    }
}
