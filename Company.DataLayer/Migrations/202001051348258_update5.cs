namespace Company.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FinalComments", "AdminUserID", c => c.String());
            AlterColumn("dbo.FinalComments", "UserID", c => c.String());
            AlterColumn("dbo.Tasks", "AdminUserID", c => c.String());
            AlterColumn("dbo.Tasks", "UserID", c => c.String());
            AlterColumn("dbo.TaskDones", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaskDones", "UserID", c => c.Long(nullable: false));
            AlterColumn("dbo.Tasks", "UserID", c => c.Long(nullable: false));
            AlterColumn("dbo.Tasks", "AdminUserID", c => c.Long(nullable: false));
            AlterColumn("dbo.FinalComments", "UserID", c => c.Long(nullable: false));
            AlterColumn("dbo.FinalComments", "AdminUserID", c => c.Long(nullable: false));
        }
    }
}
