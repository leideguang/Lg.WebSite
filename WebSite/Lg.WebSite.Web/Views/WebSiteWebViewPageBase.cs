using Abp.Web.Mvc.Views;

namespace Lg.WebSite.Web.Views
{
    public abstract class WebSiteWebViewPageBase : WebSiteWebViewPageBase<dynamic>
    {

    }

    public abstract class WebSiteWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WebSiteWebViewPageBase()
        {
            LocalizationSourceName = WebSiteConsts.LocalizationSourceName;
        }
    }
}