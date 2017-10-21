namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoHomeBrewNoCategory : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Categories");
            DropTable("dbo.HomeBrews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HomeBrews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
