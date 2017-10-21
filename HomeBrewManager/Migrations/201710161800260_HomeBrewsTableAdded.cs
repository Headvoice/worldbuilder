namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HomeBrewsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeBrews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HomeBrewUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HomeBrewUsers", t => t.HomeBrewUserId, cascadeDelete: true)
                .Index(t => t.HomeBrewUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUserId" });
            DropTable("dbo.HomeBrews");
        }
    }
}
