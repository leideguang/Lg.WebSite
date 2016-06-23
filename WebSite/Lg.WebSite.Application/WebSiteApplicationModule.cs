using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Lg.WebSite
{
    [DependsOn(typeof(WebSiteCoreModule), typeof(AbpAutoMapperModule))]
    public class WebSiteApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
