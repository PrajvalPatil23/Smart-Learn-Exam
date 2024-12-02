 using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class SubjectCheckboxVM
    {
        public List<Subject> Subjects { get; set; }
        public Int64[] SelectedSubjectIds { get; set; }
    }
}
