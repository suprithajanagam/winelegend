namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringlenght50 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "CurrencyName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "CurrencyName", c => c.String());
        }
    }
}
