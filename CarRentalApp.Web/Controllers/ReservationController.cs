using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Reservation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetReservationsByUserId(int userId)
    {
        var reservations = await _reservationService.GetReservationsByUserIdAsync(userId);
        return Ok(reservations);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetReservationById(int id)
    {
        var reservation = await _reservationService.GetReservationByIdAsync(id);
        return Ok(reservation);
    }

    [HttpPost]
    public async Task<IActionResult> AddReservation([FromBody] ReservationCreateDto reservationCreateDto)
    {
        await _reservationService.AddReservationAsync(reservationCreateDto);
        return Created("", null);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateReservation(int id, [FromBody] ReservationUpdateDto reservationUpdateDto)
    {
        await _reservationService.UpdateReservationAsync(id, reservationUpdateDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReservation(int id)
    {
        await _reservationService.DeleteReservationAsync(id);
        return NoContent();
    }
}
