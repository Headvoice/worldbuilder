namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedEntityDescriptionsToSummaryAndDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entities", "Summary", c => c.String());
            AddColumn("dbo.Entities", "Details", c => c.String());
            DropColumn("dbo.Entities", "BriefDescription");
            DropColumn("dbo.Entities", "DetailedDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entities", "DetailedDescription", c => c.String());
            AddColumn("dbo.Entities", "BriefDescription", c => c.String());
            DropColumn("dbo.Entities", "Details");
            DropColumn("dbo.Entities", "Summary");
        }
    }
}
