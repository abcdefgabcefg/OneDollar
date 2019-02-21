namespace OneDollar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DividedCinemaProductsEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CinemaProductsInfo",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 3000),
                        Duration = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        IMDB = c.Double(),
                        ImagePath = c.String(nullable: false, maxLength: 300),
                        Countries = c.Int(nullable: false),
                        Genries = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CinemaProducts", t => t.ID)
                .Index(t => t.ID);
            
            DropColumn("dbo.CinemaProducts", "Description");
            DropColumn("dbo.CinemaProducts", "Duration");
            DropColumn("dbo.CinemaProducts", "Year");
            DropColumn("dbo.CinemaProducts", "IMDB");
            DropColumn("dbo.CinemaProducts", "ImagePath");
            DropColumn("dbo.CinemaProducts", "Countries");
            DropColumn("dbo.CinemaProducts", "Genries");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CinemaProducts", "Genries", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaProducts", "Countries", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaProducts", "ImagePath", c => c.String(nullable: false, maxLength: 300));
            AddColumn("dbo.CinemaProducts", "IMDB", c => c.Double());
            AddColumn("dbo.CinemaProducts", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaProducts", "Duration", c => c.Int(nullable: false));
            AddColumn("dbo.CinemaProducts", "Description", c => c.String(nullable: false, maxLength: 3000));
            DropForeignKey("dbo.CinemaProductsInfo", "ID", "dbo.CinemaProducts");
            DropIndex("dbo.CinemaProductsInfo", new[] { "ID" });
            DropTable("dbo.CinemaProductsInfo");
        }
    }
}
