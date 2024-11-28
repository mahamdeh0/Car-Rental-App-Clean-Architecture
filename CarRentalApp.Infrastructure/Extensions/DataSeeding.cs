using CarRentalApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Infrastructure.Extensions
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(GetCars());
        }

        private static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Id = 1, Brand = "Toyota", Model = "Camry", PricePerDay = 50.00m, IsAvailable = true },
                new Car { Id = 2, Brand = "Honda", Model = "Civic", PricePerDay = 40.00m, IsAvailable = true },
                new Car { Id = 3, Brand = "BMW", Model = "X5", PricePerDay = 100.00m, IsAvailable = false }
            };
        }

    }
}
