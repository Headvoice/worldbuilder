namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToEntityCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entities", "Category", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entities", "Category", c => c.String());
        }
    }
}
