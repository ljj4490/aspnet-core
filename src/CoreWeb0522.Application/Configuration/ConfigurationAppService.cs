using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CoreWeb0522.Configuration.Dto;

namespace CoreWeb0522.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CoreWeb0522AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
