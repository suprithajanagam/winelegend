namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringlenght50codeindex : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Currencies", "CurrencyName", unique: true, name: "CurrencyName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Currencies", "CurrencyName");
        }
    }
}
