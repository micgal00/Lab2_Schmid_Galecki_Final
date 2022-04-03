namespace Forms_Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dataset_Weather",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        temp = c.Single(nullable: false),
                        feels_like = c.Single(nullable: false),
                        wind_speed = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dataset_Weather");
        }
    }
}
