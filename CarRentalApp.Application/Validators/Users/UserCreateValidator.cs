using CarRentalApp.Application.Models.Users;
using FluentValidation;

namespace CarRentalApp.Application.Validators.Users
{
    public class UserCreateValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Invalid email format");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number is required").Matches(@"^\+[1-9]\d{1,14}$").WithMessage("Phone Number must be in international format (e.g., +1234567890)");
            RuleFor(x => x.DateOfBirth).NotEmpty().When(x => x.DateOfBirth.HasValue).WithMessage("Date of Birth is required").LessThanOrEqualTo(DateTime.Now).WithMessage("Date of Birth cannot be in the future");
            RuleFor(x => x.AddressLine1).NotEmpty().WithMessage("Address Line 1 is required");
            RuleFor(x => x.AddressLine2).MaximumLength(100).WithMessage("Address Line 2 cannot exceed 100 characters");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required");
            RuleFor(x => x.DriversLicenseNumber).NotEmpty().WithMessage("Driver's License Number is required").Matches(@"^[A-Za-z0-9]+$").WithMessage("Driver's License Number must be alphanumeric");
        }
    }
}
