using System.Threading.Tasks;
using Abp.Application.Services;
using MyTestABP.Sessions.Dto;

namespace MyTestABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
