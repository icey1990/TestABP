using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTestABP.MultiTenancy.Dto;

namespace MyTestABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
