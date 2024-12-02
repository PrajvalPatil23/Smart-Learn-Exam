using Core;
using Infra.Repositories.Interfaces;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class SubjectCategoryRepo : GenericRepo<SubjectCategory>, ISubjectCategoryRepo
    {
        Context cc;

        public SubjectCategoryRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }



    }
}
