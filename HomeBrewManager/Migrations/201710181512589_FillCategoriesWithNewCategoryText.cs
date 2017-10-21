namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillCategoriesWithNewCategoryText : DbMigration
    {
        public override void Up()
        {
            

                 Sql("DELETE FROM Categories");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Galaxy')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Plane')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('World')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Region')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Settlement')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Structure')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('Vehicle')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('God')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ('DemiGod')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Race')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Monster')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Class')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Spell')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Cantrip')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'NPC')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'PC')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Item')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'Adventure')");
                 Sql("INSERT INTO Categories (CategoryText) VALUES ( 'History')");
        }
        
        public override void Down()
        {
        }
    }
}
