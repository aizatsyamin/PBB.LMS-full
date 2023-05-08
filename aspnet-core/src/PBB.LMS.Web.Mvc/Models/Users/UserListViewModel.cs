using System.Collections.Generic;
using PBB.LMS.Roles.Dto;

namespace PBB.LMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
