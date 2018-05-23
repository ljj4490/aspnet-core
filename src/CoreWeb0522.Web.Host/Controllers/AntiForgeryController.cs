using Microsoft.AspNetCore.Antiforgery;
using CoreWeb0522.Controllers;

namespace CoreWeb0522.Web.Host.Controllers
{
    public class AntiForgeryController : CoreWeb0522ControllerBase
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
