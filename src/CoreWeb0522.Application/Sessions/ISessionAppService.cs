using System.Threading.Tasks;
using Abp.Application.Services;
using CoreWeb0522.Sessions.Dto;

namespace CoreWeb0522.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
