namespace CarRentalApp.Application.Models.Cars
{
    public record CarCreateDto
    (
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
