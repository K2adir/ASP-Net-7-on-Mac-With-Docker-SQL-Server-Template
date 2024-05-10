using Microsoft.EntityFrameworkCore;
using Net8Testing.Models; 

namespace Net8Testing.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}