using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Lg.WebSite.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WebSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}