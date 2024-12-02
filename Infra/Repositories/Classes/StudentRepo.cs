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
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        Context cc;

        public StudentRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
        public RepoResultVM Register(Student rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Student urec = new Student();
                
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Gender = rec.Gender;
                urec.EmailID = rec.EmailID;
                urec.MobileNo = rec.MobileNo;
                urec.Password = rec.Password;
                urec.IsActive = true;
                
                this.cc.Students.Add(urec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public RepoResultVM ChangePassword(ChangePasswordVM rec, long userid)
        {
            var srec = this.cc.Students.Find(userid);

            RepoResultVM res = new RepoResultVM();
            if (srec.Password == rec.OldPassword)
            {
                srec.Password = rec.NewPassword;
                this.cc.SaveChanges();
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

        public RepoResultVM EditProfile(Student rec, long StudentID)
        {
            var srec = this.cc.Students.Find(StudentID);
            RepoResultVM res = new RepoResultVM();
            try
            {
                
                
                srec.MobileNo = rec.MobileNo;
                srec.EmailID = rec.EmailID;
                srec.ProfilePicture = rec.ProfilePicture;
                
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Edited!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;
        }

        public Student GetStudentProfile(long StudentID)
        {
            var rec = from t in this.cc.Students
                      where t.StudentID == StudentID
                      select new Student
                      {
                          ProfilePicture = t.ProfilePicture,
                          FirstName = t.FirstName,
                          LastName = t.LastName,
                          MobileNo = t.MobileNo,
                          EmailID = t.EmailID,
                      };

            return rec.FirstOrDefault();
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var userrec = this.cc.Students.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (userrec != null)
            {
                res.IsLoggedIn = true;
                res.LoggedName = userrec.FullName;
                res.LoggedInID = userrec.StudentID;
            }
            else
            {
                res.IsLoggedIn = false;
            }

            return res;
        }

        
    }
}
