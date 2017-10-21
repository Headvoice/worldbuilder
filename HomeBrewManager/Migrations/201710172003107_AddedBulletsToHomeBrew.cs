namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBulletsToHomeBrew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bullets", "HomeBrew_Id", c => c.Int());
            CreateIndex("dbo.Bullets", "HomeBrew_Id");
            AddForeignKey("dbo.Bullets", "HomeBrew_Id", "dbo.HomeBrews", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bullets", "HomeBrew_Id", "dbo.HomeBrews");
            DropIndex("dbo.Bullets", new[] { "HomeBrew_Id" });
            DropColumn("dbo.Bullets", "HomeBrew_Id");
        }
    }
}
