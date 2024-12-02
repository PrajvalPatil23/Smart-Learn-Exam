using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
   

        public class TopicVM
        {
           public long TopicID { get; set; }

           [Required(ErrorMessage = "Topic Name is required")]
           [StringLength(100, MinimumLength = 3, ErrorMessage = "Topic Name should be between 3 and 100 characters.")]
           public string TopicName { get; set; }
        }
}
