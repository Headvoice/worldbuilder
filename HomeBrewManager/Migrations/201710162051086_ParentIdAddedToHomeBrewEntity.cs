namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentIdAddedToHomeBrewEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HomeBrewEntities", "ParentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HomeBrewEntities", "ParentId");
        }
    }
}
