using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTestABP.Configuration;

namespace MyTestABP.Web.Host.Startup
{
    [DependsOn(
       typeof(MyTestABPWebCoreModule))]
    public class MyTestABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyTestABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTestABPWebHostModule).GetAssembly());
        }
    }
}
