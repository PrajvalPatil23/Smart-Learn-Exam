using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface IStudentRepo :IGenericRepo<Student>
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM Register(Student rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, long studentid);
        RepoResultVM EditProfile(Student rec, long studentid);
        Student GetStudentProfile(long studentid);
    }
}
