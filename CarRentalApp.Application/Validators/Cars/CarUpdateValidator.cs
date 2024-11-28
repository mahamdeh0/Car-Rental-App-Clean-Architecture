﻿using CarRentalApp.Application.Models.Cars;
using FluentValidation;

namespace CarRentalApp.Application.Validators.Cars
{
    public class CarUpdateValidator : AbstractValidator<CarUpdateDto>
    {
        public CarUpdateValidator()
        {
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Brand is required");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model is required");
            RuleFor(x => x.PricePerDay).GreaterThan(0).WithMessage("Price per day must be greater than 0");
        }
    }
}
