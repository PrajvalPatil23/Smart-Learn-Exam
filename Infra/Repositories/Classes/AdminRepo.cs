using Infra.Repositories.Interfaces;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Classes
{
    public class AdminRepo : IAdminRepo
    {
        Context cntx;
        public AdminRepo(Context cntx)
        {
            this.cntx = cntx;
        }
        public RepoResultVM ChangePassword(ChangePasswordVM rec, long AdminID)
        {
            var arec = cntx.Admins.Find(AdminID);

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



        public RepoResultVM EditProfile(AdminProfileVM rec, long AdminID)
        {
            var arec = cntx.Admins.Find(AdminID);
            RepoResultVM res = new RepoResultVM();
            try
            {
                arec.Address = rec.Address;
                arec.EmailID = rec.EmailID;
                arec.ContactPerson = rec.ContactPerson;
                arec.ContactNo = rec.ContactNo;
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

        public AdminProfileVM GetAdminProfile(long AdminID)
        {
            var rec = from t in cntx.Admins
                      where t.AdminID == AdminID
                      select new AdminProfileVM
                      {
                          Address = t.Address,
                          EmailID = t.EmailID,
                          ContactNo = t.ContactNo,
                          ContactPerson = t.ContactPerson,
                      };
            return rec.FirstOrDefault();
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var adminrec = cntx.Admins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (adminrec != null)
            {
                res.LoggedInID = adminrec.AdminID;
                res.LoggedName = adminrec.FullName;
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
