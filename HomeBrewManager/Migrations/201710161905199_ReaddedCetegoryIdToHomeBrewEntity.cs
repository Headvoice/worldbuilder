namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddedCetegoryIdToHomeBrewEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.HomeBrewEntities", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.HomeBrewEntities", "CategoryId");
            AddForeignKey("dbo.HomeBrewEntities", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeBrewEntities", "CategoryId", "dbo.Categories");
            DropIndex("dbo.HomeBrewEntities", new[] { "CategoryId" });
            DropColumn("dbo.HomeBrewEntities", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
