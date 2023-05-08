using Abp.AspNetCore.Mvc.ViewComponents;

namespace PBB.LMS.Web.Views
{
    public abstract class LMSViewComponent : AbpViewComponent
    {
        protected LMSViewComponent()
        {
            LocalizationSourceName = LMSConsts.LocalizationSourceName;
        }
    }
}
