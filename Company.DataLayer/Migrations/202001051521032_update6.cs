namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskDones", "DateOfTaskDone", c => c.DateTime(nullable: false));
            DropColumn("dbo.TaskDones", "DateOfTask");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaskDones", "DateOfTask", c => c.DateTime(nullable: false));
            DropColumn("dbo.TaskDones", "DateOfTaskDone");
        }
    }
}
