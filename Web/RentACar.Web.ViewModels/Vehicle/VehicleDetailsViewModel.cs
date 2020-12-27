namespace RentACar.Web.ViewModels.Vehicle
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.Comment;
    using RentACar.Web.ViewModels.Image;

    public class VehicleDetailsViewModel /*: IMapFrom<Vehicle>*/
    {
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public CoupeType CoupeType { get; set; }

        public int Seats { get; set; }

        public LicenseCategory RequiredLicenseCategory { get; set; }

        public FuelType FuelType { get; set; }

        public GearBoxType Gearbox { get; set; }

        public int Doors { get; set; }

        public int YearOfManufacturing { get; set; }

        public int FuelTankVolume { get; set; }

        public double FuelConsumption { get; set; }

        public double TrunkVolume { get; set; }

        public int Horsepower { get; set; }

        public double EngineVolume { get; set; }

        public decimal PricePerDay { get; set; }

        public bool IsBooked { get; set; }

        public CommentInfoInputModel Comment { get; set; }

        public IEnumerable<CommentsDetailsViewModel> LatestComments { get; set; }

        public IEnumerable<CarImagesViewModel> Images { get; set; }
    }
}
