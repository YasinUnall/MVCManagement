namespace MVCManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sevenTablesUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Region", c => c.String());
            AlterColumn("dbo.Suppliers", "Region", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Region", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Region", c => c.String(nullable: false));
        }
    }
}
