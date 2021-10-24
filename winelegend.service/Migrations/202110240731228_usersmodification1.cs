namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usersmodification1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "EmergencyContactNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "EmergencyContactNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Password");
        }
    }
}
