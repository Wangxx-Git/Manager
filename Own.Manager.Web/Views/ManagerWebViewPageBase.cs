using Abp.Web.Mvc.Views;

namespace Own.Manager.Web.Views
{
    public abstract class ManagerWebViewPageBase : ManagerWebViewPageBase<dynamic>
    {

    }

    public abstract class ManagerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ManagerWebViewPageBase()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }
    }
}