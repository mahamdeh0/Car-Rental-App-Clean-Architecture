using CarRentalApp.Application.Models.Users;

namespace CarRentalApp.Application.InterfacesService
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
        Task<UserDto> GetUserByEmailAsync(string email);
        Task AddUserAsync(UserCreateDto userCreateDto);
        Task UpdateUserAsync(int id, UserUpdateDto userUpdateDto);
        Task DeleteUserAsync(int id);
    }
}
