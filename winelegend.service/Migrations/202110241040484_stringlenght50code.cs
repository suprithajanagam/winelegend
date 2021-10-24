namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringlenght50code : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "CurrencyCode", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "CurrencyCode", c => c.String());
        }
    }
}
