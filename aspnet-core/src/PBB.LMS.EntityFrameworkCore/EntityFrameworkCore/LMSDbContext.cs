using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PBB.LMS.Authorization.Roles;
using PBB.LMS.Authorization.Users;
using PBB.LMS.MultiTenancy;

namespace PBB.LMS.EntityFrameworkCore
{
    public class LMSDbContext : AbpZeroDbContext<Tenant, Role, User, LMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LMSDbContext(DbContextOptions<LMSDbContext> options)
            : base(options)
        {
        }
    }
}
