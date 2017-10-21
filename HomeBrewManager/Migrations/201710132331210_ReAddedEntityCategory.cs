namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReAddedEntityCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entities", "Category", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Entities", "Category");
        }
    }
}
