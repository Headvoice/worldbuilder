namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedEntityCategory : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Entities", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entities", "Category", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
