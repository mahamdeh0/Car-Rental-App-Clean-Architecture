namespace CarRentalApp.Application.Models.Cars
{
    public record CarUpdateDto
    (
        string Brand,
        string Model,
        decimal PricePerDay,
        bool IsAvailable
    );
}
