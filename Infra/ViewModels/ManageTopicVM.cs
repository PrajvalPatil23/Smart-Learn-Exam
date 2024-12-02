using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class ManageTopicVM
    {
        public long SubjectID { get; set; }
        public string SubjectName { get; set; } // Read-only subject name
        public long TopicID { get; set; }

        [Required(ErrorMessage = "Topic Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Topic Name should be between 3 and 100 characters.")]
        public string TopicName { get; set; }
        [Required(ErrorMessage = "Topic Description is required")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Topic Description should be between 10 and 500 characters.")]
        public string TopicDescription { get; set; }
        public IEnumerable<TopicVM> Topics { get; set; } // List of topics
    }
}
