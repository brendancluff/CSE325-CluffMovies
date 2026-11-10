using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CluffMovies.Models;

namespace CluffMovies.Data
{
    public class CluffMoviesContext : DbContext
    {
        public CluffMoviesContext (DbContextOptions<CluffMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<CluffMovies.Models.Movie> Movie { get; set; } = default!;
    }
}
