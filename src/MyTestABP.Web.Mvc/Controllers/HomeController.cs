using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyTestABP.Controllers;

namespace MyTestABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyTestABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
