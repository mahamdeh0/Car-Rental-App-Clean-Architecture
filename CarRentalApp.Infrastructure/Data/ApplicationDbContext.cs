using CarRentalApp.Core.Entities;
using CarRentalApp.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservationConfiguration).Assembly);

        }

    }
}
