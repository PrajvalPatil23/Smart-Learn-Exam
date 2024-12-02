using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface IAdminRepo
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, long AdminID);

        RepoResultVM EditProfile(AdminProfileVM rec, long AdminID);

        AdminProfileVM GetAdminProfile(long AdminID);

    }
}
