using Abp.Application.Services;
using Abp.Application.Services.Dto;
using APIClub.MultiTenancy.Dto;

namespace APIClub.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
