namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTypeChangedToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entities", "Category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entities", "Category", c => c.Short(nullable: false));
        }
    }
}
