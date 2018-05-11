using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyTestABP.Web.Views
{
    public abstract class MyTestABPViewComponent : AbpViewComponent
    {
        protected MyTestABPViewComponent()
        {
            LocalizationSourceName = MyTestABPConsts.LocalizationSourceName;
        }
    }
}
