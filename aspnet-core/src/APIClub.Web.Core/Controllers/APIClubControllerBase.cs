using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace APIClub.Controllers
{
    public abstract class APIClubControllerBase: AbpController
    {
        protected APIClubControllerBase()
        {
            LocalizationSourceName = APIClubConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
