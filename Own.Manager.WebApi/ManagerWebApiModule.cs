using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Own.Manager
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ManagerApplicationModule))]
    public class ManagerWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ManagerApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
