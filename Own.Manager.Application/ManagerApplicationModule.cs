using System.Reflection;
using Abp.Modules;
using Abp.AutoMapper;

namespace Own.Manager
{
    [DependsOn(typeof(ManagerCoreModule), typeof(AbpAutoMapperModule))]
    public class ManagerApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
