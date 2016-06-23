using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Lg.WebSite.EntityFramework;

namespace Lg.WebSite
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(WebSiteCoreModule))]
    public class WebSiteDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<WebSiteDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
