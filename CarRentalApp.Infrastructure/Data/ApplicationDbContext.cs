using CarRentalApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Reservation> Reservation { get; set; } = null!;

    }
}
