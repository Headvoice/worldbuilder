namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Value) VALUES ('Galaxy')");
            Sql("INSERT INTO Categories (Value) VALUES ('Plane')");
            Sql("INSERT INTO Categories (Value) VALUES ('World')");
            Sql("INSERT INTO Categories (Value) VALUES ('Region')");
            Sql("INSERT INTO Categories (Value) VALUES ('Settlement')");
            Sql("INSERT INTO Categories (Value) VALUES ('Structure')");
            Sql("INSERT INTO Categories (Value) VALUES ('Vehicle')");
            Sql("INSERT INTO Categories (Value) VALUES ('God')");
            Sql("INSERT INTO Categories (Value) VALUES ('DemiGod')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Race')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Monster')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Class')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Spell')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Cantrip')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'NPC')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'PC')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Item')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'Adventure')");
            Sql("INSERT INTO Categories (Value) VALUES ( 'History')");
 

        }
        
        public override void Down()
        {
        }
    }
}
