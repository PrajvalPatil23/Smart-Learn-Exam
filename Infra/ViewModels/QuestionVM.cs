using Core.Enums;
using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Infra.ViewModels
{
    public class QuestionVM

    {
        public long QuestionID {  get; set; }    
        [Required(ErrorMessage = "Question Title is required")]
        public string QuestionTitle { get; set; }

        public string QuestionDescription { get; set; }

        [Required(ErrorMessage = "Topic is required")]
        public long TopicID { get; set; }
        public string TopicName { get; set; } 
        public virtual List<Topic> Topics { get; set; }
        

        
    }

}
