using Microsoft.AspNetCore.Antiforgery;
using MyTestABP.Controllers;

namespace MyTestABP.Web.Host.Controllers
{
    public class AntiForgeryController : MyTestABPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
