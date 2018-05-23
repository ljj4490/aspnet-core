using System.Threading.Tasks;
using Abp.Application.Services;
using CoreWeb0522.Authorization.Accounts.Dto;

namespace CoreWeb0522.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
