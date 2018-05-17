using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using APIClub.Roles.Dto;
using APIClub.Users.Dto;

namespace APIClub.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
