using System.Web.Mvc;

namespace Lg.WebSite.Web.Controllers
{
    public class AboutController : WebSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}