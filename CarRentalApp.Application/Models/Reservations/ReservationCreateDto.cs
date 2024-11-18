namespace CarRentalApp.Application.Models.Reservation
{
    public record ReservationCreateDto
   (
       int CarId,
       int UserId,
       DateTime StartDate,
       DateTime EndDate,
       decimal TotalCost
   );
}
