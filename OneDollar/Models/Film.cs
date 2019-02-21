using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OneDollar.Models
{
    public class Film : CinemaProduct
    {
        [Required]
        [MaxLength(300, ErrorMessage = "Max path lenght's 300")]
        public string Video { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Max path lenght's 300")]
        public string Trailer { get; set; }
    }
}