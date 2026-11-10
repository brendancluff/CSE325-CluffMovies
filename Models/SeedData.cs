
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CluffMovies.Data;

namespace CluffMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new CluffMoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CluffMoviesContext>>());

        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "The Lord of the Rings",
                ReleaseDate = DateTime.Parse("2001-12-19"),
                Genre = "Fantasy",
                Price = 9.99M
            },
            new Movie
            {
                Title = "The Matrix",
                ReleaseDate = DateTime.Parse("1999-03-31"),
                Genre = "Science Fiction",
                Price = 9.99M
            },
            new Movie
            {
                Title = "Jurassic Park",
                ReleaseDate = DateTime.Parse("1993-06-11"),
                Genre = "Adventure",
                Price = 9.99M
            }
        );

        context.SaveChanges();
    }
}
