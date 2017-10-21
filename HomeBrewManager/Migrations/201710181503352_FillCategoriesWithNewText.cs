namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillCategoriesWithNewText : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Categories");
            Sql("INSERT INTO Categories (Text) VALUES ('Galaxy')");
            Sql("INSERT INTO Categories (Text) VALUES ('Plane')");
            Sql("INSERT INTO Categories (Text) VALUES ('World')");
            Sql("INSERT INTO Categories (Text) VALUES ('Region')");
            Sql("INSERT INTO Categories (Text) VALUES ('Settlement')");
            Sql("INSERT INTO Categories (Text) VALUES ('Structure')");
            Sql("INSERT INTO Categories (Text) VALUES ('Vehicle')");
            Sql("INSERT INTO Categories (Text) VALUES ('God')");
            Sql("INSERT INTO Categories (Text) VALUES ('DemiGod')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Race')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Monster')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Class')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Spell')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Cantrip')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'NPC')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'PC')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Item')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'Adventure')");
            Sql("INSERT INTO Categories (Text) VALUES ( 'History')");
        }
        
        public override void Down()
        {
        }
    }
}
