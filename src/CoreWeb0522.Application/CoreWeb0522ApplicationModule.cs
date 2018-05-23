using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreWeb0522.Authorization;

namespace CoreWeb0522
{
    [DependsOn(
        typeof(CoreWeb0522CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CoreWeb0522ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CoreWeb0522AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CoreWeb0522ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
