using System.Threading.Tasks;
using Abp.Application.Services;
using PBB.LMS.Authorization.Accounts.Dto;

namespace PBB.LMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
