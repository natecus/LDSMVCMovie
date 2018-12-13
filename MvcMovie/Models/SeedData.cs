using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Down and Derby",
                        ReleaseDate = DateTime.Parse("12-12-1212"),
                        Genre = "Comedy",
                        Rating ="PG",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("12-12-1212"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 14.99M
                    },
                    new Movie
                    {
                        Title = "President Russell M. Nelson: Brilliant Mind, Gentle Heart",
                        ReleaseDate = DateTime.Parse("12-12-1212"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("12-12-1212"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Family Night with John Bytheway",
                        ReleaseDate = DateTime.Parse("12-12-1212"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
