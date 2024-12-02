using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Interfaces
{
    public interface ICompanyAdminRepo
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, long CompanyAdminID);

        RepoResultVM EditProfile(AdminProfileVM rec, long CompanyAdminID);

        AdminProfileVM GetAdminProfile(long CompanyAdminID);
    }
}
