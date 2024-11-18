using CarRentalApp.Core.Entities;

namespace CarRentalApp.Core.InterfacesRepository
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAvailableCarsAsync(DateTime date);
        Task<Car> GetCarByIdAsync(int id);
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int id);
    }
}
