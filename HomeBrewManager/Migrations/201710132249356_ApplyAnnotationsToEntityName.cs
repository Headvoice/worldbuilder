namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToEntityName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entities", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entities", "Name", c => c.String());
        }
    }
}
