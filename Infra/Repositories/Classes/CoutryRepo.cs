using Core;
using Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class CoutryRepo : GenericRepo<Country>, ICountryRepo
    {
        Context cc;

        public CoutryRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
