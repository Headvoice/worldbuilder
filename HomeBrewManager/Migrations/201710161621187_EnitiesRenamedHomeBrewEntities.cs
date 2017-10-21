namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnitiesRenamedHomeBrewEntities : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Entities", newName: "HomeBrewEntities");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.HomeBrewEntities", newName: "Entities");
        }
    }
}
