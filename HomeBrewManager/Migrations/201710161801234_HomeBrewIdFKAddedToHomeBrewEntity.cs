namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HomeBrewIdFKAddedToHomeBrewEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUserId" });
            DropColumn("dbo.HomeBrews", "HomeBrewUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HomeBrews", "HomeBrewUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.HomeBrews", "HomeBrewUserId");
            AddForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers", "Id", cascadeDelete: true);
        }
    }
}
