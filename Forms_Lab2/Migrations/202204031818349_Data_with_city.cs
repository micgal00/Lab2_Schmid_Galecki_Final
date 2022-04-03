namespace Forms_Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data_with_city : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dataset_Weather", "city", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dataset_Weather", "city");
        }
    }
}
