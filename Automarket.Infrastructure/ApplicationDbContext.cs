using Automarket.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Automarket.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Car> Car { get; set; }
    }
}