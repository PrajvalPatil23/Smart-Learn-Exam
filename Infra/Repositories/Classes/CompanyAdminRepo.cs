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
    public class CompanyAdminRepo : ICompanyAdminRepo
    {
        Context cntx;
        public CompanyAdminRepo(Context cntx)
        {
            this.cntx = cntx;
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, long CompanyAdminID)
        {
            var arec = cntx.CompanyAdmins.Find(CompanyAdminID);

            RepoResultVM res = new RepoResultVM();
            if (arec.Password == rec.OldPassword)
            {
                arec.Password = rec.NewPassword;
                cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed!";

            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;

        }

        public RepoResultVM EditProfile(AdminProfileVM rec, long CompanyAdminID)
        {
            var arec = cntx.CompanyAdmins.Find(CompanyAdminID);
            RepoResultVM res = new RepoResultVM();
            try
            {
                arec.Address = rec.Address;
                arec.EmailID = rec.EmailID;
                arec.MobileNo = rec.ContactNo;
                cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Edited";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public AdminProfileVM GetAdminProfile(long CompanyAdminID)
        {
            var rec = from t in cntx.CompanyAdmins
                      where t.CompanyAdminID == CompanyAdminID
                      select new AdminProfileVM
                      {
                          Address = t.Address,
                          EmailID = t.EmailID,
                          ContactNo = t.MobileNo,

                      };
            return rec.FirstOrDefault();
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var companyadminrec = cntx.CompanyAdmins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (companyadminrec != null)
            {
                res.LoggedInID = companyadminrec.CompanyAdminID;
                res.LoggedName = companyadminrec.FullName;
                res.IsLoggedIn = true;
            }
            else
            {
                res.IsLoggedIn = false;
            }
            return res;
        }
    }


}

