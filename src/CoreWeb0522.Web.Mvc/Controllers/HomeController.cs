using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CoreWeb0522.Controllers;

namespace CoreWeb0522.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CoreWeb0522ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
