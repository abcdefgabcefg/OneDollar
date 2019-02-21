namespace OneDollar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedNavigationsProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MainRoles", "FirstName", c => c.String());
            AddColumn("dbo.MainRoles", "LastName", c => c.String());
            AddColumn("dbo.Producers", "FirstName", c => c.String());
            AddColumn("dbo.Producers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Producers", "LastName");
            DropColumn("dbo.Producers", "FirstName");
            DropColumn("dbo.MainRoles", "LastName");
            DropColumn("dbo.MainRoles", "FirstName");
        }
    }
}
