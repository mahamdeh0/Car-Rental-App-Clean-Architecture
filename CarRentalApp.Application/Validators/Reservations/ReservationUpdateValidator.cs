using CarRentalApp.Application.Models.Reservation;
using FluentValidation;

namespace CarRentalApp.Application.Validators.Reservations
{
    public class ReservationUpdateValidator : AbstractValidator<ReservationUpdateDto>
    {
        public ReservationUpdateValidator()
        {
            RuleFor(x => x.CarId).GreaterThan(0).WithMessage("CarId is required");
            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("UserId is required");
            RuleFor(x => x.StartDate).LessThan(x => x.EndDate).WithMessage("StartDate must be before EndDate");
            RuleFor(x => x.TotalCost).GreaterThan(0).WithMessage("Total cost must be greater than 0");
        }
    }
}
