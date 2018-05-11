using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MyTestABP.Web.Views
{
    public abstract class MyTestABPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyTestABPRazorPage()
        {
            LocalizationSourceName = MyTestABPConsts.LocalizationSourceName;
        }
    }
}
