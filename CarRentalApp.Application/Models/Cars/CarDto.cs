namespace CarRentalApp.Application.Models.Cars
{
    public record CarDto
    (
        int Id,
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
