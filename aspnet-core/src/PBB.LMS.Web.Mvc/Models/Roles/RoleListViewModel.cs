using System.Collections.Generic;
using PBB.LMS.Roles.Dto;

namespace PBB.LMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
