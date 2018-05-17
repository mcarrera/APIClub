using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using APIClub.Configuration;

namespace APIClub.Web.Host.Startup
{
    [DependsOn(
       typeof(APIClubWebCoreModule))]
    public class APIClubWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public APIClubWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(APIClubWebHostModule).GetAssembly());
        }
    }
}
