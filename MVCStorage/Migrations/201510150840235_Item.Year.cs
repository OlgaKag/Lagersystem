namespace MVCStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Year");
        }
    }
}
