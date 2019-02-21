namespace OneDollar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTVShowEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 3000),
                        Year = c.Int(nullable: false),
                        TVShowID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TVShows", t => t.TVShowID)
                .Index(t => t.TVShowID);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        Description = c.String(nullable: false, maxLength: 3000),
                        Duration = c.Int(nullable: false),
                        Video = c.String(nullable: false, maxLength: 300),
                        SeasonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Seasons", t => t.SeasonID, cascadeDelete: true)
                .Index(t => t.SeasonID);
            
            CreateTable(
                "dbo.TVShows",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CinemaProducts", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TVShows", "ID", "dbo.CinemaProducts");
            DropForeignKey("dbo.Seasons", "TVShowID", "dbo.TVShows");
            DropForeignKey("dbo.Series", "SeasonID", "dbo.Seasons");
            DropIndex("dbo.TVShows", new[] { "ID" });
            DropIndex("dbo.Series", new[] { "SeasonID" });
            DropIndex("dbo.Seasons", new[] { "TVShowID" });
            DropTable("dbo.TVShows");
            DropTable("dbo.Series");
            DropTable("dbo.Seasons");
        }
    }
}
