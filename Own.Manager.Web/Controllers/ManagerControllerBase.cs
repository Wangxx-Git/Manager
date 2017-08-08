using Abp.Web.Mvc.Controllers;

namespace Own.Manager.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ManagerControllerBase : AbpController
    {
        protected ManagerControllerBase()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }
    }
}