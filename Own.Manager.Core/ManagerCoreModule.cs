using System.Reflection;
using Abp.Modules;

namespace Own.Manager
{
    public class ManagerCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
