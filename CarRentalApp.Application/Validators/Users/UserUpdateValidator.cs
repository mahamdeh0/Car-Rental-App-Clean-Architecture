using CarRentalApp.Application.Models.Users;
using FluentValidation;

namespace CarRentalApp.Application.Validators.Users
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email format");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone Number is required");
        }
    }
}
