namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecurrencycode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Currencies", "CurrencyCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Currencies", "CurrencyCode");
        }
    }
}
