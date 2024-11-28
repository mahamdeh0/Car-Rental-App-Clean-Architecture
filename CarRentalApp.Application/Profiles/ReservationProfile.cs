using AutoMapper;
using CarRentalApp.Application.Models.Reservation;
using CarRentalApp.Core.Entities;

namespace CarRentalApp.Application.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<ReservationCreateDto, Reservation>();
            CreateMap<ReservationUpdateDto, Reservation>().ReverseMap();
        }
    }
}
