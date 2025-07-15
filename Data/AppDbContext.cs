using Microsoft.EntityFrameworkCore;
using RoyalJelly.Models;

namespace RoyalJelly.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
