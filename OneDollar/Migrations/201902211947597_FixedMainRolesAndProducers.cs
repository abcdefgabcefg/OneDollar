namespace OneDollar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedMainRolesAndProducers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MainRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CinemaProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CinemaProducts", t => t.CinemaProductID, cascadeDelete: true)
                .Index(t => t.CinemaProductID);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CinemaProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CinemaProducts", t => t.CinemaProductID, cascadeDelete: true)
                .Index(t => t.CinemaProductID);
            
            AlterColumn("dbo.CinemaProducts", "IMDB", c => c.Double());
            AlterColumn("dbo.CinemaProducts", "ImagePath", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producers", "CinemaProductID", "dbo.CinemaProducts");
            DropForeignKey("dbo.MainRoles", "CinemaProductID", "dbo.CinemaProducts");
            DropIndex("dbo.Producers", new[] { "CinemaProductID" });
            DropIndex("dbo.MainRoles", new[] { "CinemaProductID" });
            AlterColumn("dbo.CinemaProducts", "ImagePath", c => c.String(nullable: false));
            AlterColumn("dbo.CinemaProducts", "IMDB", c => c.Double(nullable: false));
            DropTable("dbo.Producers");
            DropTable("dbo.MainRoles");
        }
    }
}
