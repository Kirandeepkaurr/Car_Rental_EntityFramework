﻿// <auto-generated />
using Car_Rental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Car_Rental.Migrations
{
    [DbContext(typeof(Car_RentalContext))]
    [Migration("20191005223207_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Car_Rental.Models.Booking", b =>
                {
                    b.Property<string>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarId");

                    b.Property<int>("NumberOfDays");

                    b.Property<string>("UserId");

                    b.HasKey("BookingId");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Car_Rental.Models.Car", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarMake");

                    b.Property<string>("CarModel");

                    b.Property<string>("CarRegNo");

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("PricePerDay");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Car_Rental.Models.Driver", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarId");

                    b.Property<string>("DriverName");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique()
                        .HasFilter("[CarId] IS NOT NULL");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Car_Rental.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Car_Rental.Models.Booking", b =>
                {
                    b.HasOne("Car_Rental.Models.Car", "Car")
                        .WithMany("Bookings")
                        .HasForeignKey("CarId");

                    b.HasOne("Car_Rental.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Car_Rental.Models.Driver", b =>
                {
                    b.HasOne("Car_Rental.Models.Car", "Car")
                        .WithOne("Driver")
                        .HasForeignKey("Car_Rental.Models.Driver", "CarId");
                });
#pragma warning restore 612, 618
        }
    }
}