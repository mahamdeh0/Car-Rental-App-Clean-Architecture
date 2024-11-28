using CarRentalApp.Application.Models.Reservation;

namespace CarRentalApp.Application.InterfacesService
{
    public interface IReservationService
    {
        Task<List<ReservationDto>> GetReservationsByUserIdAsync(int userId);
        Task<ReservationDto> GetReservationByIdAsync(int reservationId);
        Task AddReservationAsync(ReservationCreateDto reservationCreateDto);
        Task UpdateReservationAsync(int id, ReservationUpdateDto reservationUpdateDto);
        Task DeleteReservationAsync(int id);
    }
}
