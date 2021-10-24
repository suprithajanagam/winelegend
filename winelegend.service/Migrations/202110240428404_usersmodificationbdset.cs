namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usersmodificationbdset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        EmergencyContactNumber = c.Int(nullable: false),
                        EmergencyContactPersonName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        PasswordSalt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
