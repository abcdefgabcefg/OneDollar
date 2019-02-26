using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OneDollar.Models;

namespace OneDollar.DAL
{
    public class CinemaProductsContextInitializer : DropCreateDatabaseAlways<CinemaProductsContext>
    {
        protected override void Seed(CinemaProductsContext context)
        {
            var cinProds = new CinemaProduct[]
            {
                new Film
                {
                    Title = "The Shawshank Redemption",
                    Description =
                    "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Duration = 142,
                    Year = 1994,
                    IMDB = 9.3,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.USA,
                    Genres = GenresEnum.Drama,

                    Actors = new[]
                    {
                       new Actor
                       {
                          CinemaProductID = 1,
                          FirstName = "Tim",
                          LastName = "Robbins"
                       },
                       new Actor
                       {
                          CinemaProductID = 1,
                          FirstName = "Morgan",
                          LastName = "Freeman"
                       },
                       new Actor
                       {
                          CinemaProductID = 1,
                          FirstName = "Bob",
                          LastName = "Gunton"
                       }
                    },

                    Directors =new[]
                    {
                       new Director
                       {
                          CinemaProductID = 1,
                          FirstName = "Frank",
                          LastName = "Darabont"
                       }
                     },

                    Video = "Here is URL",
                    Trailer = "Here is URL",
                },

                new TVShow
                {
                    Title = "Planet Earth II",
                    Description =
                    "David Attenborough returns in this breathtaking documentary showcasing life on Planet Earth.",
                    Duration = 6 * 60,
                    Year = 2016,
                    IMDB = 9.5,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BZWYxODViMGYtMGE2ZC00ZGQ3LThhMWUtYTVkNGE3OWU4NWRkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMjYwNDA2MDE@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.UK,
                    Genres = GenresEnum.Documentary,

                    Actors = new[]
                    {
                        new Actor
                        {
                            CinemaProductID = 2,
                            FirstName = "David",
                            LastName = "Attenborough"
                        }
                    },

                    Directors = new Director[0],

                    Seasons = new[]
                    {
                        new Season
                        {
                            Number = 1,
                            Year = 2017,
                            TVShowID = 2,
                            Serieses = new[]
                            {
                                new Series
                                {
                                    Title = "Islands",
                                    Description = "Wildlife documentary series with David Attenborough, " +
                                    "beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures",
                                    Duration = 60,
                                    Video = "Here is URL",
                                    SeasonID = 1
                                }
                            }
                        }
                    }
                },

                new Film
                {
                    Title = "The Godfather",
                    Description =
                    "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    Duration = 2 * 60 + 55,
                    Year = 1972,
                    IMDB = 9.2,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.USA,
                    Genres = GenresEnum.Drama | GenresEnum.Crime,

                    Actors = new[]
                    {
                        new Actor
                        {
                            CinemaProductID = 3,
                            FirstName = "Marlon",
                            LastName = "Brando"
                        },
                        new Actor
                        {
                            CinemaProductID = 3,
                            FirstName = "Al",
                            LastName = "Pacino"
                        },
                        new Actor
                        {
                            CinemaProductID = 3,
                            FirstName = "James",
                            LastName = "Caan"
                        }
                    },

                    Directors = new[]
                    {
                        new Director
                        {
                            CinemaProductID = 3,
                            FirstName = "Francis",
                            LastName = "Coppola"
                        }
                    },
                    
                    Video = "Here is URL",
                    Trailer = "Here is URL"
                },

                new Film
                {
                    Title = "The Dark Knight",
                    Description =
                    "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. " +
                    "The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Duration = 2 * 60 + 32,
                    Year = 2008,
                    IMDB = 9.0,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.USA | CountriesEnum.UK,
                    Genres = GenresEnum.Action | GenresEnum.Crime | GenresEnum.Drama,

                    Actors = new[]
                    {
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Christian",
                            LastName = "Bale"
                        },
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Heath",
                            LastName = "Ledger"
                        },
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Aaron",
                            LastName = "Eckhart"
                        }
                    },

                    Directors = new[]
                    {
                        new Director
                        {
                            CinemaProductID = 4,
                            FirstName = "Christopher",
                            LastName = "Nolan"
                        }
                    },

                    Video = "Here is URL",
                    Trailer = "Here is URL"
                },

                new Film
                {
                    Title = "The Godfather: Part II",
                    Description =
                    "The early life and career of Vito Corleone in 1920s New York City is portrayed, " +
                    "while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    Duration = 3 * 60 + 22,
                    Year = 1974,
                    IMDB = 9.0,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.USA,
                    Genres = GenresEnum.Crime | GenresEnum.Drama,

                    Actors = new[]
                    {
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Al",
                            LastName = "Pacino"
                        },
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Robert",
                            LastName = "De Niro"
                        },
                        new Actor
                        {
                            CinemaProductID = 4,
                            FirstName = "Robert",
                            LastName = "Duvall"
                        }
                    },

                    Directors = new[]
                    {
                        new Director
                        {
                            CinemaProductID = 4,
                            FirstName = "Francis",
                            LastName = "Coppola"
                        }
                    },

                    Video = "Here is URL",
                    Trailer = "Here is URL"
                },

                new Film
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army " +
                    "to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    Duration = 3 * 60 + 21,
                    Year = 2004,
                    IMDB = 8.9,
                    ImagePath =
                    "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Countries = CountriesEnum.USA | CountriesEnum.NewZealand,
                    Genres = GenresEnum.Adventure | GenresEnum.Drama | GenresEnum.Fantasy,

                    Actors = new[]
                    {
                        new Actor
                        {
                            CinemaProductID = 5,
                            FirstName = "Elijah",
                            LastName = "Wood"
                        },
                        new Actor
                        {
                            CinemaProductID = 5,
                            FirstName = "Viggo",
                            LastName = "Mortensen"
                        },
                        new Actor
                        {
                            CinemaProductID = 5,
                            FirstName = "Ian",
                            LastName = "McKellen"
                        }
                    },

                    Directors = new[]
                    {
                        new Director
                        {
                            CinemaProductID = 6,
                            FirstName = "Peter",
                            LastName = "Jackson"
                        }
                    },

                    Video = "Here is URL",
                    Trailer = "Here is URL"
                }
            };

            context.CinemaProducts.AddRange(cinProds);
            context.SaveChanges();
        }
    }
}