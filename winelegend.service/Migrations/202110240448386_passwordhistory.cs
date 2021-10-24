namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordhistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PasswordsHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        OldPassword = c.String(),
                        NewPassword = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PasswordsHistories", "UserId", "dbo.Users");
            DropIndex("dbo.PasswordsHistories", new[] { "UserId" });
            DropTable("dbo.PasswordsHistories");
        }
    }
}
