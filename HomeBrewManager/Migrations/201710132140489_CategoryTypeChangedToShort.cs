namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTypeChangedToShort : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entities", "Category", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entities", "Category", c => c.Int(nullable: false));
        }
    }
}
