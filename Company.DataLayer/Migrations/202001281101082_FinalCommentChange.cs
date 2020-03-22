namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalCommentChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FinalComments", "Project_ProjectID", "dbo.Projects");
            DropIndex("dbo.FinalComments", new[] { "Project_ProjectID" });
            DropColumn("dbo.FinalComments", "ProjectID");
            RenameColumn(table: "dbo.FinalComments", name: "Project_ProjectID", newName: "ProjectID");
            AlterColumn("dbo.FinalComments", "ProjectID", c => c.Long(nullable: false));
            AlterColumn("dbo.FinalComments", "ProjectID", c => c.Long(nullable: false));
            CreateIndex("dbo.FinalComments", "ProjectID");
            AddForeignKey("dbo.FinalComments", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FinalComments", "ProjectID", "dbo.Projects");
            DropIndex("dbo.FinalComments", new[] { "ProjectID" });
            AlterColumn("dbo.FinalComments", "ProjectID", c => c.Long());
            AlterColumn("dbo.FinalComments", "ProjectID", c => c.String());
            RenameColumn(table: "dbo.FinalComments", name: "ProjectID", newName: "Project_ProjectID");
            AddColumn("dbo.FinalComments", "ProjectID", c => c.String());
            CreateIndex("dbo.FinalComments", "Project_ProjectID");
            AddForeignKey("dbo.FinalComments", "Project_ProjectID", "dbo.Projects", "ProjectID");
        }
    }
}
