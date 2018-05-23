using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreWeb0522.MultiTenancy.Dto;

namespace CoreWeb0522.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
