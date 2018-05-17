using System.Threading.Tasks;
using Abp.Application.Services;
using APIClub.Authorization.Accounts.Dto;

namespace APIClub.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
