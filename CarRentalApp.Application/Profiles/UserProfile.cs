using AutoMapper;
using CarRentalApp.Application.Models.Users;
using CarRentalApp.Core.Entities;

namespace CarRentalApp.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
