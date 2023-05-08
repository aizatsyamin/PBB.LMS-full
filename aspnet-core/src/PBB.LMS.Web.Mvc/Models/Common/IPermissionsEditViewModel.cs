using System.Collections.Generic;
using PBB.LMS.Roles.Dto;

namespace PBB.LMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}