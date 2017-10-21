namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddedHomeBrewIdToHomeBrewEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUserId" });
            RenameColumn(table: "dbo.HomeBrews", name: "HomeBrewUserId", newName: "HomeBrewUser_Id");
            AddColumn("dbo.HomeBrewEntities", "HomeBrewId", c => c.Int(nullable: false));
            AlterColumn("dbo.HomeBrews", "HomeBrewUser_Id", c => c.Int());
            CreateIndex("dbo.HomeBrewEntities", "HomeBrewId");
            CreateIndex("dbo.HomeBrews", "HomeBrewUser_Id");
            AddForeignKey("dbo.HomeBrewEntities", "HomeBrewId", "dbo.HomeBrews", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HomeBrews", "HomeBrewUser_Id", "dbo.HomeBrewUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUser_Id", "dbo.HomeBrewUsers");
            DropForeignKey("dbo.HomeBrewEntities", "HomeBrewId", "dbo.HomeBrews");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUser_Id" });
            DropIndex("dbo.HomeBrewEntities", new[] { "HomeBrewId" });
            AlterColumn("dbo.HomeBrews", "HomeBrewUser_Id", c => c.Int(nullable: false));
            DropColumn("dbo.HomeBrewEntities", "HomeBrewId");
            RenameColumn(table: "dbo.HomeBrews", name: "HomeBrewUser_Id", newName: "HomeBrewUserId");
            CreateIndex("dbo.HomeBrews", "HomeBrewUserId");
            AddForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers", "Id", cascadeDelete: true);
        }
    }
}
