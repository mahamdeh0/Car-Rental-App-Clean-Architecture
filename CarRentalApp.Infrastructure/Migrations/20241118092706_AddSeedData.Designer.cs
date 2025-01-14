﻿// <auto-generated />
using System;
using CarRentalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241118092706_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarRentalApp.Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("brand");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit")
                        .HasColumnName("is_available");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("model");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price_per_day");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Toyota",
                            IsAvailable = true,
                            Model = "Camry",
                            PricePerDay = 50.00m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Honda",
                            IsAvailable = true,
                            Model = "Civic",
                            PricePerDay = 40.00m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "BMW",
                            IsAvailable = false,
                            Model = "X5",
                            PricePerDay = 100.00m
                        });
                });

            modelBuilder.Entity("CarRentalApp.Core.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_date");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("total_cost");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CarRentalApp.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address_line1");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address_line2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("country");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("DriversLicenseNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("drivers_license_number");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CarRentalApp.Core.Entities.Reservation", b =>
                {
                    b.HasOne("CarRentalApp.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
