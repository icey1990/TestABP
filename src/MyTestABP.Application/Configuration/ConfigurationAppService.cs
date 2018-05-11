using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyTestABP.Configuration.Dto;

namespace MyTestABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyTestABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
