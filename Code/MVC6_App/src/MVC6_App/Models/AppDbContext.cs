using Microsoft.Data.Entity;
using MVC6_App.Models;

namespace MVC6_App.Models
{
    public class AppDbContext : DbContext
    {
        private static bool _created = false;

        public AppDbContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
