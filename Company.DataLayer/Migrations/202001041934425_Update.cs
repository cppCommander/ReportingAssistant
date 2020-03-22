namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.FinalComments",
                c => new
                    {
                        FinalCommentID = c.Long(nullable: false, identity: true),
                        Screen = c.String(),
                        Description = c.String(),
                        AdminUserID = c.Long(nullable: false),
                        UserID = c.Long(nullable: false),
                        DateOfFinalComment = c.DateTime(nullable: false),
                        Attachment = c.String(),
                        ProjectID = c.String(),
                        Project_ProjectID = c.Long(),
                    })
                .PrimaryKey(t => t.FinalCommentID)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID)
                .Index(t => t.Project_ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Long(nullable: false, identity: true),
                        ProjectName = c.String(),
                        DateOfStart = c.DateTime(nullable: false),
                        AvailabilityStatus = c.Boolean(nullable: false),
                        CategoryID = c.Long(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Long(nullable: false, identity: true),
                        Screen = c.String(),
                        Description = c.String(),
                        AdminUserID = c.Long(nullable: false),
                        UserID = c.Long(nullable: false),
                        DateOfTask = c.DateTime(nullable: false),
                        Attachment = c.String(),
                        ProjectID = c.String(),
                        Project_ProjectID = c.Long(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID)
                .Index(t => t.Project_ProjectID);
            
            CreateTable(
                "dbo.TaskDones",
                c => new
                    {
                        TaskDoneID = c.Long(nullable: false, identity: true),
                        Screen = c.String(),
                        Description = c.String(),
                        UserID = c.Long(nullable: false),
                        DateOfTask = c.DateTime(nullable: false),
                        Attachment = c.String(),
                        ProjectID = c.String(),
                        Project_ProjectID = c.Long(),
                    })
                .PrimaryKey(t => t.TaskDoneID)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectID)
                .Index(t => t.Project_ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskDones", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Tasks", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.FinalComments", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Projects", "CategoryID", "dbo.Categories");
            DropIndex("dbo.TaskDones", new[] { "Project_ProjectID" });
            DropIndex("dbo.Tasks", new[] { "Project_ProjectID" });
            DropIndex("dbo.Projects", new[] { "CategoryID" });
            DropIndex("dbo.FinalComments", new[] { "Project_ProjectID" });
            DropTable("dbo.TaskDones");
            DropTable("dbo.Tasks");
            DropTable("dbo.Projects");
            DropTable("dbo.FinalComments");
            DropTable("dbo.Categories");
        }
    }
}
