namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriesTextPropToCategoryText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryText", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Categories", "Text");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Text", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Categories", "CategoryText");
        }
    }
}
