namespace Own.Manager.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class _201703151433 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActionPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionName = c.String(nullable: false),
                        ControllerName = c.String(nullable: false),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ActionPermission_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                        RoleCode = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        User_Id = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Role_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuName = c.String(nullable: false),
                        MenuCode = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        ActionName = c.String(nullable: false),
                        ControllerName = c.String(nullable: false),
                        SmallIcon = c.String(),
                        BigIcon = c.String(),
                        Remark = c.String(),
                        Index = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Menu_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false),
                        DeptCode = c.String(nullable: false),
                        Level = c.Int(nullable: false),
                        Index = c.Int(nullable: false),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Department_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        LoginName = c.String(nullable: false),
                        PassWord = c.String(nullable: false),
                        Email = c.String(),
                        Remark = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_User_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleActionPermissions",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        ActionPermission_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.ActionPermission_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.ActionPermissions", t => t.ActionPermission_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.ActionPermission_Id);
            
            CreateTable(
                "dbo.MenuRoles",
                c => new
                    {
                        Menu_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_Id, t.Role_Id })
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Menu_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.UserDepartments",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Department_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserDepartments", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.UserDepartments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.MenuRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.MenuRoles", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.RoleActionPermissions", "ActionPermission_Id", "dbo.ActionPermissions");
            DropForeignKey("dbo.RoleActionPermissions", "Role_Id", "dbo.Roles");
            DropIndex("dbo.UserDepartments", new[] { "Department_Id" });
            DropIndex("dbo.UserDepartments", new[] { "User_Id" });
            DropIndex("dbo.MenuRoles", new[] { "Role_Id" });
            DropIndex("dbo.MenuRoles", new[] { "Menu_Id" });
            DropIndex("dbo.RoleActionPermissions", new[] { "ActionPermission_Id" });
            DropIndex("dbo.RoleActionPermissions", new[] { "Role_Id" });
            DropIndex("dbo.Roles", new[] { "User_Id" });
            DropTable("dbo.UserDepartments");
            DropTable("dbo.MenuRoles");
            DropTable("dbo.RoleActionPermissions");
            DropTable("dbo.Users",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_User_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Departments",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Department_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Menus",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Menu_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Roles",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Role_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.ActionPermissions",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_ActionPermission_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
