namespace DALForEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeUserColumnsSize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
