using Abp.Application.Services;

namespace Own.Manager
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ManagerAppServiceBase : ApplicationService
    {
        protected ManagerAppServiceBase()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }
    }
}