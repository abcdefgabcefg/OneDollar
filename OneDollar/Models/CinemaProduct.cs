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
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [MaxLength(3000, ErrorMessage ="Max description lenght's 3000")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        // in minutes
        [Required(ErrorMessage = "Duration is required")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        public double? IMDB { get; set; }

        [Required(ErrorMessage = "Image path is required")]
        [MaxLength(300, ErrorMessage ="Max path lenght's 300" )]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "At least one country is required")]
        public CountriesEnum Countries { get; set; }

        [Required(ErrorMessage = "At least one genre is required")]
        public GenresEnum Genres { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
    }

    [Flags]
    public enum CountriesEnum
    {
        USA = 1,
        Canada = 2,
        China = 4,
        UK = 8,
        Japan = 16,
        India = 32,
        [Display(Name = "New Zealand")]
        NewZealand = 64
    }

    [Flags]
    public enum GenresEnum
    {
        Adventure = 1,
        Action = 2,
        Drama = 4,
        Comedy = 8,
        Thriller = 16,
        Horror = 32,
        Romantic = 64,
        Musical = 128,
        Documentary = 256,
        Crime = 512,
        Fantasy = 1024
    }

    public class Actor
    {
        public int ID { get; set; }

        public int CinemaProductID { get; set; }

        [Required(ErrorMessage ="First name is required")]
        [MaxLength(60, ErrorMessage = "Max first name lenght's 60")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(60, ErrorMessage = "Max last name lenght's 60")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }

    public class Director
    {
        public int ID { get; set; }

        public int CinemaProductID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(60, ErrorMessage = "Max first name lenght's 60")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(60, ErrorMessage = "Max last name lenght's 60")]
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