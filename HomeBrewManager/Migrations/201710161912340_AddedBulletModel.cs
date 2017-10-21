namespace HomeBrewManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBulletModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bullets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompositeKey = c.String(),
                        HomeBrewEntityId = c.Int(nullable: false),
                        PositionIndex = c.Short(nullable: false),
                        Value = c.String(nullable: false, maxLength: 150),
                        IsPlayerVisibleBullet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bullets");
        }
    }
}
