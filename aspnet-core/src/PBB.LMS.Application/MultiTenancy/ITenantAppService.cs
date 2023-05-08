using Abp.Application.Services;
using PBB.LMS.MultiTenancy.Dto;

namespace PBB.LMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

