namespace CarRentalApp.Application.Models.Reservation
{
    public record ReservationUpdateDto
  (
      int CarId,
      int UserId,
      DateTime StartDate,
      DateTime EndDate,
      decimal TotalCost
  );
}
