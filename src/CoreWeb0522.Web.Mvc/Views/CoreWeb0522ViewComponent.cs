using Abp.AspNetCore.Mvc.ViewComponents;

namespace CoreWeb0522.Web.Views
{
    public abstract class CoreWeb0522ViewComponent : AbpViewComponent
    {
        protected CoreWeb0522ViewComponent()
        {
            LocalizationSourceName = CoreWeb0522Consts.LocalizationSourceName;
        }
    }
}
