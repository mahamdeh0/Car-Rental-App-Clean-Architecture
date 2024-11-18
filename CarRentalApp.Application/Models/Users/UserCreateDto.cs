﻿namespace CarRentalApp.Application.Models.Users
{
    public record UserCreateDto
       (
           string FirstName,
           string LastName,
           string Email,
           string PhoneNumber,
           DateTime? DateOfBirth,
           string AddressLine1,
           string AddressLine2,
           string City,
           string Country,
           string DriversLicenseNumber,
           string PasswordHash
       );
}