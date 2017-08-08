using System.Data.Entity.Migrations;
using Own.Manager.Authority;

namespace Own.Manager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Manager.EntityFramework.ManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Manager";
        }

        protected override void Seed(Manager.EntityFramework.ManagerDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

            context.Users.Add(new User() {LoginName = "admin", UserName = "管理员", PassWord = "admin"});
            context.Users.Add(new User() {LoginName = "wangxixing", UserName = "王西星", PassWord = "wangxixing" });
            context.SaveChanges();
        }
    }
}
