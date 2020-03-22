namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategoryAndProjectModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 450));
            AlterColumn("dbo.Projects", "ProjectName", c => c.String(maxLength: 450));
            CreateIndex("dbo.Categories", "CategoryName", unique: true);
            CreateIndex("dbo.Projects", "ProjectName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Projects", new[] { "ProjectName" });
            DropIndex("dbo.Categories", new[] { "CategoryName" });
            AlterColumn("dbo.Projects", "ProjectName", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
        }
    }
}
