namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityDetailsRenamedGameMasterNotes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entities", "GameMasterNotes", c => c.String());
            DropColumn("dbo.Entities", "Details");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entities", "Details", c => c.String());
            DropColumn("dbo.Entities", "GameMasterNotes");
        }
    }
}
