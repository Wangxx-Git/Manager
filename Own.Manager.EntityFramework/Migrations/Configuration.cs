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

            context.Users.Add(new User() {LoginName = "admin", UserName = "����Ա", PassWord = "admin"});
            context.Users.Add(new User() {LoginName = "wangxixing", UserName = "������", PassWord = "wangxixing" });
            context.SaveChanges();
        }
    }
}
