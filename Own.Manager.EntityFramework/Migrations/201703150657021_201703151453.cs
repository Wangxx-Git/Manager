namespace Own.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201703151453 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserDepartments", newName: "DepartmentUsers");
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropIndex("dbo.Roles", new[] { "User_Id" });
            DropPrimaryKey("dbo.DepartmentUsers");
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Role_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Role_Id);
            
            AddPrimaryKey("dbo.DepartmentUsers", new[] { "Department_Id", "User_Id" });
            DropColumn("dbo.Roles", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "User_Id", c => c.Int());
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropPrimaryKey("dbo.DepartmentUsers");
            DropTable("dbo.UserRoles");
            AddPrimaryKey("dbo.DepartmentUsers", new[] { "User_Id", "Department_Id" });
            CreateIndex("dbo.Roles", "User_Id");
            AddForeignKey("dbo.Roles", "User_Id", "dbo.Users", "Id");
            RenameTable(name: "dbo.DepartmentUsers", newName: "UserDepartments");
        }
    }
}
