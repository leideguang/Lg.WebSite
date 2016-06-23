using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Lg.WebSite.Authorization;
using Lg.WebSite.MultiTenancy;

namespace Lg.WebSite.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : WebSiteControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}