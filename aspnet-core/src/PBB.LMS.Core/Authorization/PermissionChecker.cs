using Abp.Authorization;
using PBB.LMS.Authorization.Roles;
using PBB.LMS.Authorization.Users;

namespace PBB.LMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
