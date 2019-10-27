using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorWebMovie.Models
{
    public class RazorWebMovieContext : DbContext
    {
        public RazorWebMovieContext (DbContextOptions<RazorWebMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorWebMovie.Models.Movie> Movie { get; set; }
    }
}
