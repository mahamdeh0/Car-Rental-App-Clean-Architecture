namespace CarRentalApp.Application.Models.Reservation
{
    public record ReservationDto
    (
        int Id,
        int CarId,
        int UserId,
        DateTime StartDate,
        DateTime EndDate,
        decimal TotalCost
    );
}
