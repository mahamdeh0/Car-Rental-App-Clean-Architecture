using CarRentalApp.Application.Models.Cars;

namespace CarRentalApp.Application.InterfacesService
{
    public interface ICarService
    {
        Task<List<CarDto>> GetAvailableCarsAsync();
        Task<CarDto> GetCarByIdAsync(int id);
        Task AddCarAsync(CarCreateDto carCreateDto);
        Task UpdateCarAsync(int id, CarUpdateDto carUpdateDto);
        Task DeleteCarAsync(int id);
    }
}
