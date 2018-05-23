using System.Threading.Tasks;
using CoreWeb0522.Configuration.Dto;

namespace CoreWeb0522.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
