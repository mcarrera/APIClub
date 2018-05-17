using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using APIClub.Authorization;

namespace APIClub
{
    [DependsOn(
        typeof(APIClubCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class APIClubApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<APIClubAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(APIClubApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
