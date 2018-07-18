using carsdealer.Models;
using Microsoft.EntityFrameworkCore;

namespace carsdealer.Persistence
{
    public class CarsDealerDbContext : DbContext
    {
        public CarsDealerDbContext(DbContextOptions<CarsDealerDbContext> options)
        : base(options)
        {
            
        }
        public DbSet<Make> Makes { get; set; }
    }
}