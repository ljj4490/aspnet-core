using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CoreWeb0522.Controllers
{
    public abstract class CoreWeb0522ControllerBase: AbpController
    {
        protected CoreWeb0522ControllerBase()
        {
            LocalizationSourceName = CoreWeb0522Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
