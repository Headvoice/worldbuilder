namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCategoryPropertyValueToText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Text", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Categories", "Value");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Value", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Categories", "Text");
        }
    }
}
