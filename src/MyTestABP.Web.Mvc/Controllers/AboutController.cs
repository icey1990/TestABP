using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyTestABP.Controllers;

namespace MyTestABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MyTestABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
