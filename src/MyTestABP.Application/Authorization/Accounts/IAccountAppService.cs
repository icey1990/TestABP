using System.Threading.Tasks;
using Abp.Application.Services;
using MyTestABP.Authorization.Accounts.Dto;

namespace MyTestABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
