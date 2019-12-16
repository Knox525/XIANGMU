namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hfdsgsf : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ActionLinks", newName: "ActionLinks1");
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ActionLinks");
            RenameTable(name: "dbo.ActionLinks1", newName: "ActionLinks");
        }
    }
}
