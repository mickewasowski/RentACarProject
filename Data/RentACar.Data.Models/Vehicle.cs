namespace RentACar.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using RentACar.Data.Common.Models;

    public class Vehicle : BaseModel<string>, IDeletableEntity
    {
        public Vehicle()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Ratings = new HashSet<Rating>();
            this.Pictures = new HashSet<Picture>();
        }

        [Required]
        [MaxLength(25)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(25)]
        public string Model { get; set; }

        public CoupeType CoupeType { get; set; }

        [Range(2, 45, ErrorMessage ="Please enter valid seats number!")]
        public int Seats { get; set; }

        [Required]
        public char RequiredLicenseCategory { get; set; }

        public FuelType FuelType { get; set; }

        public GearBoxType Gearbox { get; set; }

        [Range(2, 7, ErrorMessage ="Please enter a valid door number!")]
        public int Doors { get; set; }

        public int YearOfManufacturing { get; set; }

        public int FuelTankVolume { get; set; }

        public double FuelConsumption { get; set; }

        public double TrunkVolume { get; set; }

        public int Horsepower { get; set; }

        public double EngineVolume { get; set; }

        public bool IsBooked { get; set; }

        public decimal PricePerDay { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        // Deletable entity
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
