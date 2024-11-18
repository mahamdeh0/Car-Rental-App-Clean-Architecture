using AutoMapper;
using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Reservation;
using CarRentalApp.Core.Entities;
using CarRentalApp.Core.InterfacesRepository;

namespace CarRentalApp.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<List<ReservationDto>> GetReservationsByUserIdAsync(int userId)
        {
            var reservations = await _reservationRepository.GetReservationsByUserIdAsync(userId);
            return _mapper.Map<List<ReservationDto>>(reservations);
        }

        public async Task<ReservationDto> GetReservationByIdAsync(int reservationId)
        {
            var reservation = await _reservationRepository.GetReservationByIdAsync(reservationId);
            return _mapper.Map<ReservationDto>(reservation);
        }

        public async Task AddReservationAsync(ReservationCreateDto reservationCreateDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationCreateDto);
            await _reservationRepository.AddReservationAsync(reservation);
        }

        public async Task UpdateReservationAsync(int reservationId, ReservationUpdateDto reservationUpdateDto)
        {
            var reservation = await _reservationRepository.GetReservationByIdAsync(reservationId);
            if (reservation == null)
                throw new Exception("Reservation not found.");

            _mapper.Map(reservationUpdateDto, reservation);
            await _reservationRepository.UpdateReservationAsync(reservation);
        }

        public async Task DeleteReservationAsync(int reservationId)
        {
            var reservation = await _reservationRepository.GetReservationByIdAsync(reservationId);
            if (reservation == null)
                throw new Exception("Reservation not found.");

            await _reservationRepository.DeleteReservationAsync(reservationId);
        }
    }
}
