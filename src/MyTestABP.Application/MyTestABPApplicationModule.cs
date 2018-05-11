using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTestABP.Authorization;

namespace MyTestABP
{
    [DependsOn(
        typeof(MyTestABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyTestABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyTestABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyTestABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
