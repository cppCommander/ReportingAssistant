namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            DropColumn("dbo.Categories", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CompanyName", c => c.String());
            DropColumn("dbo.Categories", "CategoryName");
        }
    }
}
