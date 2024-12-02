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
    public class CityRepo : GenericRepo<City>, ICityRepo
    {
        Context cc;
        public CityRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
        public List<CityVM> GetCitiesByStateID(long stateid)
        {
            var res = from t in this.cc.Cities
                      where t.StateID == stateid
                      select new CityVM
                      {
                          CityID = t.CityID,
                          CityName = t.CityName
                      };
            return res.ToList();
        }
    }
}
