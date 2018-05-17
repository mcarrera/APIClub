using System.Threading.Tasks;
using APIClub.Configuration.Dto;

namespace APIClub.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
