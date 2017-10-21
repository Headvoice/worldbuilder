namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserChangedToHomeBrewUser : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "HomeBrewUsers");
            DropColumn("dbo.HomeBrewEntities", "ParentId");
            DropColumn("dbo.HomeBrewEntities", "Category");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.HomeBrewEntities", "Category", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.HomeBrewEntities", "ParentId", c => c.Int(nullable: false));
            RenameTable(name: "dbo.HomeBrewUsers", newName: "Users");
        }
    }
}
