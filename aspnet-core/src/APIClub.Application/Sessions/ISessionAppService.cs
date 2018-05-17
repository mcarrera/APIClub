using System.Threading.Tasks;
using Abp.Application.Services;
using APIClub.Sessions.Dto;

namespace APIClub.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
