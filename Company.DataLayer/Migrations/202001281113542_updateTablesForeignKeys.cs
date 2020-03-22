namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTablesForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tasks", "Project_ProjectID", "dbo.Projects");
            DropForeignKey("dbo.TaskDones", "Project_ProjectID", "dbo.Projects");
            DropIndex("dbo.Tasks", new[] { "Project_ProjectID" });
            DropIndex("dbo.TaskDones", new[] { "Project_ProjectID" });
            DropColumn("dbo.Tasks", "ProjectID");
            DropColumn("dbo.TaskDones", "ProjectID");
            RenameColumn(table: "dbo.Tasks", name: "Project_ProjectID", newName: "ProjectID");
            RenameColumn(table: "dbo.TaskDones", name: "Project_ProjectID", newName: "ProjectID");
            AlterColumn("dbo.Tasks", "ProjectID", c => c.Long(nullable: false));
            AlterColumn("dbo.Tasks", "ProjectID", c => c.Long(nullable: false));
            AlterColumn("dbo.TaskDones", "ProjectID", c => c.Long(nullable: false));
            AlterColumn("dbo.TaskDones", "ProjectID", c => c.Long(nullable: false));
            CreateIndex("dbo.Tasks", "ProjectID");
            CreateIndex("dbo.TaskDones", "ProjectID");
            AddForeignKey("dbo.Tasks", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
            AddForeignKey("dbo.TaskDones", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskDones", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Tasks", "ProjectID", "dbo.Projects");
            DropIndex("dbo.TaskDones", new[] { "ProjectID" });
            DropIndex("dbo.Tasks", new[] { "ProjectID" });
            AlterColumn("dbo.TaskDones", "ProjectID", c => c.Long());
            AlterColumn("dbo.TaskDones", "ProjectID", c => c.String());
            AlterColumn("dbo.Tasks", "ProjectID", c => c.Long());
            AlterColumn("dbo.Tasks", "ProjectID", c => c.String());
            RenameColumn(table: "dbo.TaskDones", name: "ProjectID", newName: "Project_ProjectID");
            RenameColumn(table: "dbo.Tasks", name: "ProjectID", newName: "Project_ProjectID");
            AddColumn("dbo.TaskDones", "ProjectID", c => c.String());
            AddColumn("dbo.Tasks", "ProjectID", c => c.String());
            CreateIndex("dbo.TaskDones", "Project_ProjectID");
            CreateIndex("dbo.Tasks", "Project_ProjectID");
            AddForeignKey("dbo.TaskDones", "Project_ProjectID", "dbo.Projects", "ProjectID");
            AddForeignKey("dbo.Tasks", "Project_ProjectID", "dbo.Projects", "ProjectID");
        }
    }
}
