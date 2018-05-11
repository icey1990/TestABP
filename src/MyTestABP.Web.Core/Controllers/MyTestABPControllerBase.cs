using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyTestABP.Controllers
{
    public abstract class MyTestABPControllerBase: AbpController
    {
        protected MyTestABPControllerBase()
        {
            LocalizationSourceName = MyTestABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
