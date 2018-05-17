using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using APIClub.Configuration.Dto;

namespace APIClub.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : APIClubAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
