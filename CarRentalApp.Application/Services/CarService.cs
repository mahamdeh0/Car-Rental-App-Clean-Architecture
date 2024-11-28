using AutoMapper;
using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Cars;
using CarRentalApp.Core.Entities;
using CarRentalApp.Core.InterfacesRepository;

namespace CarRentalApp.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<CarDto>> GetAvailableCarsAsync()
        {
            var cars = await _carRepository.GetAvailableCarsAsync();
            return _mapper.Map<List<CarDto>>(cars);
        }

        public async Task<CarDto> GetCarByIdAsync(int id)
        {
            var car = await _carRepository.GetCarByIdAsync(id);
            return _mapper.Map<CarDto>(car);
        }

        public async Task AddCarAsync(CarCreateDto carCreateDto)
        {
            var car = _mapper.Map<Car>(carCreateDto);
            await _carRepository.AddCarAsync(car);
        }

        public async Task UpdateCarAsync(int id, CarUpdateDto carUpdateDto)
        {
            var car = await _carRepository.GetCarByIdAsync(id);
            if (car != null)
            {
                _mapper.Map(carUpdateDto, car);
                await _carRepository.UpdateCarAsync(car);
            }
        }

        public async Task DeleteCarAsync(int id)
        {
            await _carRepository.DeleteCarAsync(id);
        }
    }
}
