using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OneDollar.Models
{
    public class TVShow : CinemaProduct
    {
        public virtual ICollection<Season> Seasons { get; set; }
    }

    public class Season
    {
        private int number;

        public int ID { get; set; }
        [Required]
        public int Number {
            get
            {
                return number;
            }
            set
            {
                if (value > 0)
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Number have to be grater than zero");
                }
            }
        }
        [MaxLength(3000, ErrorMessage = "Max description lenght's 3000")]
        public string Description { get; set; }
        [Required]
        public int Year { get; set; }
        public int TVShowID { get; set; }

        public virtual ICollection<Series> Serieses { get; set; }
    }

    public class Series
    {
        public int ID { get; set; }
        [MaxLength(60, ErrorMessage = "Max title lenght's 3000")]
        [Required]
        public string Title { get; set; }
        [MaxLength(3000, ErrorMessage = "Max description lenght's 3000")]
        [Required]
        public string Description { get; set; }
        // in minutes
        [Required]
        public int Duration { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Max path lenght's 300")]
        public string Video { get; set; }
        public int SeasonID { get; set; }
    }
}