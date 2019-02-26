using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OneDollar.Models;
using System.Data.Entity;

namespace OneDollar.DAL
{
    public class CinemaProductsContext : DbContext
    {
        public DbSet<CinemaProduct> CinemaProducts { get; set; }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }

        public DbSet<Season> Seasons { get; set; }
        public DbSet<Series> Serieses { get; set; }

        public CinemaProductsContext()
        {
            Database.SetInitializer(new CinemaProductsContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CinemaProduct>().Map(map =>
            {
                map.Properties(p => new
                {
                    p.ID,
                    p.Title,
                    p.Description
                });
                map.ToTable("CinemaProducts");
            })
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.Duration,
                    p.Year,
                    p.IMDB,
                    p.ImagePath,
                    p.Countries,
                    p.Genres
                });
                map.ToTable("CinemaProductsInfo");
            });

            modelBuilder.Entity<Film>().ToTable("Films");
            modelBuilder.Entity<TVShow>().ToTable("TVShows");
        }
    }
}