using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace CoreWeb0522.Web.Views
{
    public abstract class CoreWeb0522RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CoreWeb0522RazorPage()
        {
            LocalizationSourceName = CoreWeb0522Consts.LocalizationSourceName;
        }
    }
}
