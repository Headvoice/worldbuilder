namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescriptionForPlayersAndGameMasterNotesAddedToHomeBrew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HomeBrews", "DescriptionForPlayers", c => c.String());
            AddColumn("dbo.HomeBrews", "GameMasterNotes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HomeBrews", "GameMasterNotes");
            DropColumn("dbo.HomeBrews", "DescriptionForPlayers");
        }
    }
}
