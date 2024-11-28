using CarRentalApp.Core.Entities;
using CarRentalApp.Core.InterfacesRepository;
using CarRentalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetAvailableCarsAsync()
        {
            try
            {
                return await _context.Cars.Where(c => c.IsAvailable).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching available cars.", ex);
            }
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);
                if (car == null)
                {
                    throw new KeyNotFoundException($"Car with ID {id} not found.");
                }
                return car;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching car by ID.", ex);
            }
        }

        public async Task AddCarAsync(Car car)
        {
            try
            {
                await _context.Cars.AddAsync(car);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding car.", ex);
            }
        }

        public async Task UpdateCarAsync(Car car)
        {
            try
            {
                var existingCar = await _context.Cars.FindAsync(car.Id);
                if (existingCar == null)
                {
                    throw new KeyNotFoundException($"Car with ID {car.Id} not found.");
                }

                existingCar.Brand = car.Brand;
                existingCar.Model = car.Model;
                existingCar.PricePerDay = car.PricePerDay;
                existingCar.IsAvailable = car.IsAvailable;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating car.", ex);
            }
        }

        public async Task DeleteCarAsync(int id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);
                if (car != null)
                {
                    _context.Cars.Remove(car);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new KeyNotFoundException($"Car with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting car.", ex);
            }
        }
    }
}
