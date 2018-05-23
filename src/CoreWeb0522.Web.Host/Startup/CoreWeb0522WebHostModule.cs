using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreWeb0522.Configuration;

namespace CoreWeb0522.Web.Host.Startup
{
    [DependsOn(
       typeof(CoreWeb0522WebCoreModule))]
    public class CoreWeb0522WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CoreWeb0522WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreWeb0522WebHostModule).GetAssembly());
        }
    }
}
