using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CompanyAdminTbl")]
    public class CompanyAdmin
    {
        [Key]
        [Required]
        public Int64 CompanyAdminID {  get; set; }
        [Required]
        [ForeignKey("CompanyID")]
        public Int64 CompanyID {  get; set; }
        [Required]
        public string FirstName {  get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }


        [Required]
        [EmailAddress]

        public string EmailID {  get; set; }
        [Required]
        [RegularExpression(@"\^[0-9]{10}$")]
        public string MobileNo {  get; set; }
        [Required]
        public string Address {  get; set; }
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [ForeignKey("City")]
        public Int64 CityID {  get; set; }
        public virtual City City { get; set; }
    }
}
