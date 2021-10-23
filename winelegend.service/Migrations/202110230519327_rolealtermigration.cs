namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rolealtermigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "RoleName", c => c.String(nullable: false));
            DropColumn("dbo.Roles", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Roles", "RoleName");
        }
    }
}
