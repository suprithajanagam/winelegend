namespace winelegend.service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorymigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Guid(nullable: false),
                        SubCategoryId = c.Guid(nullable: false),
                        BrandName = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Guid(nullable: false),
                        CategoryName = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Guid(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                        SubCategoryName = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.SubCategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
