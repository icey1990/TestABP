using System.Threading.Tasks;
using MyTestABP.Configuration.Dto;

namespace MyTestABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
