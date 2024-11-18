using AutoMapper;
using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Users;
using CarRentalApp.Core.Entities;

namespace CarRentalApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            return _mapper.Map<UserDto>(user);
        }

        public async Task AddUserAsync(UserCreateDto userCreateDto)
        {
            var user = _mapper.Map<User>(userCreateDto);
            await _userRepository.AddUserAsync(user);
        }

        public async Task UpdateUserAsync(int userId, UserUpdateDto userUpdateDto)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
                throw new Exception("User not found.");

            _mapper.Map(userUpdateDto, user);
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
                throw new Exception("User not found.");

            await _userRepository.DeleteUserAsync(userId);
        }
    }
}
