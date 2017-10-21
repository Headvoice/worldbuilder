namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoBulletsInHomeBrewAndHomeBrewEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bullets", "HomeBrewEntityId", "dbo.HomeBrewEntities");
            DropForeignKey("dbo.Bullets", "HomeBrew_Id", "dbo.HomeBrews");
            DropIndex("dbo.Bullets", new[] { "HomeBrewEntityId" });
            DropIndex("dbo.Bullets", new[] { "HomeBrew_Id" });
            DropColumn("dbo.Bullets", "HomeBrew_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bullets", "HomeBrew_Id", c => c.Int());
            CreateIndex("dbo.Bullets", "HomeBrew_Id");
            CreateIndex("dbo.Bullets", "HomeBrewEntityId");
            AddForeignKey("dbo.Bullets", "HomeBrew_Id", "dbo.HomeBrews", "Id");
            AddForeignKey("dbo.Bullets", "HomeBrewEntityId", "dbo.HomeBrewEntities", "Id", cascadeDelete: true);
        }
    }
}
