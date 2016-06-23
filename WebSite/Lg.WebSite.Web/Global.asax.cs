using System;
using Abp.Web;
using Castle.Facilities.Logging;
using System.Web.Optimization;

namespace Lg.WebSite.Web
{
    public class MvcApplication : AbpWebApplication
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            BundleTable.EnableOptimizations = true;
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));
            base.Application_Start(sender, e);
        }
    }
}
