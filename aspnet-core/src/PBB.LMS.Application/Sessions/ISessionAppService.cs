using System.Threading.Tasks;
using Abp.Application.Services;
using PBB.LMS.Sessions.Dto;

namespace PBB.LMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
