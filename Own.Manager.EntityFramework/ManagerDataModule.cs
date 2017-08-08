using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Own.Manager.EntityFramework;

namespace Own.Manager
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ManagerCoreModule))]
    public class ManagerDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ManagerDbContext>(new CreateDatabaseIfNotExists<ManagerDbContext>());
        }
    }
}
