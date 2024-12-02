using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TopicTbl")]
    public class Topic
    {
        [Key]
        public Int64 TopicID {  get; set; }
        
        [Required(ErrorMessage = "Topic Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Topic Name should be between 3 and 100 characters.")]
        public string TopicName { get; set; }
        public Int64 SubjectID {  get; set; }
        [Required(ErrorMessage = "Topic Description is required")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Topic Description should be between 10 and 500 characters.")]
        public string TopicDescription {  get; set; }

    }
}
