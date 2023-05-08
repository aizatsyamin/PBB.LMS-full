using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PBB.LMS.Web.Views
{
    public abstract class LMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LMSRazorPage()
        {
            LocalizationSourceName = LMSConsts.LocalizationSourceName;
        }
    }
}
