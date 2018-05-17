using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using APIClub.Roles.Dto;

namespace APIClub.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
