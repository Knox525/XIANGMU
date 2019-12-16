namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserUpadte2019121215 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActionLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.classs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CourseManagements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ClassId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SideBars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                        Controller = c.String(nullable: false, maxLength: 20, unicode: false),
                        Action = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.student",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 10, fixedLength: true),
                        xuehao = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.teacher",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10, fixedLength: true),
                        xingbie = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        Password = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.teacher");
            DropTable("dbo.student");
            DropTable("dbo.SideBars");
            DropTable("dbo.CourseManagements");
            DropTable("dbo.Courses");
            DropTable("dbo.classs");
            DropTable("dbo.ActionLinks");
        }
    }
}
