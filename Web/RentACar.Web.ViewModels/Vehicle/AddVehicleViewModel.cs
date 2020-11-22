namespace RentACar.Web.ViewModels.Vehicle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using RentACar.Data.Models;

    public class AddVehicleViewModel
    {
        [Required]
        [MaxLength(25)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(25)]
        public string Model { get; set; }

        public CoupeType CoupeType { get; set; }

        [Range(2, 45, ErrorMessage = "Please enter valid seats number!")]
        public int Seats { get; set; }

        [Required]
        public LicenseCategory RequiredLicenseCategory { get; set; }

        public FuelType FuelType { get; set; }

        public GearBoxType Gearbox { get; set; }

        [Range(2, 7, ErrorMessage = "Please enter a valid door number!")]
        public int Doors { get; set; }

        public int YearOfManufacturing { get; set; }

        public int FuelTankVolume { get; set; }

        public double FuelConsumption { get; set; }

        public double TrunkVolume { get; set; }

        public int Horsepower { get; set; }

        public double EngineVolume { get; set; }

        public decimal PricePerDay { get; set; }

        public ICollection<IFormFile> Pictures { get; set; }
    }
}
