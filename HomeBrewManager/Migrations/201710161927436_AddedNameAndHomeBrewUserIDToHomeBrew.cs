namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameAndHomeBrewUserIDToHomeBrew : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUser_Id", "dbo.HomeBrewUsers");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUser_Id" });
            RenameColumn(table: "dbo.HomeBrews", name: "HomeBrewUser_Id", newName: "HomeBrewUserId");
            AddColumn("dbo.HomeBrews", "Name", c => c.String());
            AlterColumn("dbo.HomeBrews", "HomeBrewUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bullets", "HomeBrewEntityId");
            CreateIndex("dbo.HomeBrews", "HomeBrewUserId");
            AddForeignKey("dbo.Bullets", "HomeBrewEntityId", "dbo.HomeBrewEntities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeBrews", "HomeBrewUserId", "dbo.HomeBrewUsers");
            DropForeignKey("dbo.Bullets", "HomeBrewEntityId", "dbo.HomeBrewEntities");
            DropIndex("dbo.HomeBrews", new[] { "HomeBrewUserId" });
            DropIndex("dbo.Bullets", new[] { "HomeBrewEntityId" });
            AlterColumn("dbo.HomeBrews", "HomeBrewUserId", c => c.Int());
            DropColumn("dbo.HomeBrews", "Name");
            RenameColumn(table: "dbo.HomeBrews", name: "HomeBrewUserId", newName: "HomeBrewUser_Id");
            CreateIndex("dbo.HomeBrews", "HomeBrewUser_Id");
            AddForeignKey("dbo.HomeBrews", "HomeBrewUser_Id", "dbo.HomeBrewUsers", "Id");
        }
    }
}
