using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Lg.WebSite.EntityFramework;

namespace Lg.WebSite.Migrator
{
    [DependsOn(typeof(WebSiteDataModule))]
    public class WebSiteMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<WebSiteDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}