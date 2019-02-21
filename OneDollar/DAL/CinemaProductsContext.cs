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
        public DbSet<MainRole> MainRoles { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Series> Serieses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CinemaProduct>().Map(map =>
            {
                map.Properties(p => new
                {
                    p.ID,
                    p.Title
                });
                map.ToTable("CinemaProducts");
            })
            .Map(map =>
            {
                map.Properties(p => new
                {
                    p.Description,
                    p.Duration,
                    p.Year,
                    p.IMDB,
                    p.ImagePath,
                    p.Countries,
                    p.Genries
                });
                map.ToTable("CinemaProductsInfo");
            });

            modelBuilder.Entity<Film>().ToTable("Films");
            modelBuilder.Entity<TVShow>().ToTable("TVShows");
        }
    }
}