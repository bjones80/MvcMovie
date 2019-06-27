using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Genres.AddRange(
                    new Genre
                    {
                        GenreName = "Comedy"
                    },
                    new Genre
                    {
                        GenreName = "Adventure"
                    },
                    new Genre
                    {
                        GenreName = "Action"
                    },
                    new Genre
                    {
                        GenreName = "Crime"
                    },
                    new Genre
                    {
                        GenreName = "Romance"
                    },
                     new Genre
                     {
                         GenreName = "Historical"
                     },
                      new Genre
                      {
                          GenreName = "Church"
                      }

                 );
                context.SaveChanges();

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Rating = "R",
                        GenreId = 79,
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Rating = "G",
                        GenreId = 79,
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "G",
                        GenreId = 79,
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Rating = "G",
                        GenreId = 79,
                        Price = 3.99M
                    }
                ) ;

               
                context.SaveChanges();
            }
        }
    }
}
