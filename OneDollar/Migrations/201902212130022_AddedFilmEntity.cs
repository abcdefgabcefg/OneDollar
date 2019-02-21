namespace OneDollar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFilmEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Video = c.String(nullable: false, maxLength: 300),
                        Trailer = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CinemaProducts", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "ID", "dbo.CinemaProducts");
            DropIndex("dbo.Films", new[] { "ID" });
            DropTable("dbo.Films");
        }
    }
}
