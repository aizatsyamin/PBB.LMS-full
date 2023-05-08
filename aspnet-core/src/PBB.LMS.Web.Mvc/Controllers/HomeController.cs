using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PBB.LMS.Controllers;

namespace PBB.LMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
