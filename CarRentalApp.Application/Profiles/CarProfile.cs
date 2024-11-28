using AutoMapper;
using CarRentalApp.Application.Models.Cars;
using CarRentalApp.Core.Entities;

namespace CarRentalApp.Application.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>().ReverseMap();
        }
    }
}
