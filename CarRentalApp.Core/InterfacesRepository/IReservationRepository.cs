using CarRentalApp.Core.Entities;

namespace CarRentalApp.Core.InterfacesRepository
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetReservationsByUserIdAsync(int userId);
        Task<Reservation> GetReservationByIdAsync(int reservationId);
        Task AddReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int reservationId);
    }
}
