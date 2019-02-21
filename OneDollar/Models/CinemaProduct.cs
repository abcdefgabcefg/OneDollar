using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OneDollar.Models
{
    public abstract class CinemaProduct
    {
        public int ID { get; set; }
        [MaxLength(60, ErrorMessage ="Max title lenght's 3000")]
        [Required]
        public string Title { get; set; }
        [MaxLength(3000, ErrorMessage ="Max description lenght's 3000")]
        [Required]
        public string Description { get; set; }
        // in minutes
        [Required]
        public int Duration { get; set; }
        [Required]
        public int Year { get; set; }
        public double? IMDB { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage ="Max path lenght's 300" )]
        public string ImagePath { get; set; }
        [Required]
        public CountriesEnum Countries { get; set; }
        [Required]
        public GenriesEnum Genries { get; set; }

        public virtual ICollection<MainRole> MainRoles { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
    }

    [Flags]
    public enum CountriesEnum
    {
        USA = 1,
        Canada = 2,
        China = 4,
        UK = 8,
        Japan = 16,
        India = 32
    }

    [Flags]
    public enum GenriesEnum
    {
        Adventure = 1,
        Action = 2,
        Drama = 4,
        Comedy = 8,
        Thriller = 16,
        Horror = 32,
        Romantic = 64,
        Musical = 128,
        Documentary = 256
    }

    public class MainRole
    {
        public int ID { get; set; }
        public int CinemaProductID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }

    public class Producer
    {
        public int ID { get; set; }
        public int CinemaProductID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}