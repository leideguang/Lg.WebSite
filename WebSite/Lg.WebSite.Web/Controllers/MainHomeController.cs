using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lg.WebSite.Web.Controllers
{
    public class MainHomeController : Controller
    {
        // GET: MainHome
        public ActionResult Index()
        {
            return View();
        }
    }
}