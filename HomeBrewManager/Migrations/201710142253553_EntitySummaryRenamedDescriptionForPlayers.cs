namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitySummaryRenamedDescriptionForPlayers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entities", "DescriptionForPlayers", c => c.String());
            DropColumn("dbo.Entities", "Summary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entities", "Summary", c => c.String());
            DropColumn("dbo.Entities", "DescriptionForPlayers");
        }
    }
}
