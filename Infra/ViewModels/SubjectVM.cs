using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class SubjectVM
    {
        public long SubjectID { get; set; }
        [Required(ErrorMessage = "Subject Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Subject Name should be between 3 and 100 characters.")]
        public string SubjectName { get; set; }
        public int TopicCount { get; set; } // Count of topics per subject
    }
}
