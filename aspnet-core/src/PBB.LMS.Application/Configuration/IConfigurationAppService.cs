using System.Threading.Tasks;
using PBB.LMS.Configuration.Dto;

namespace PBB.LMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
