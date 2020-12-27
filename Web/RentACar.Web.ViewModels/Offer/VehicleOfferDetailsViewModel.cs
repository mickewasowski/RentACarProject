namespace RentACar.Web.ViewModels.Offer
{
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class VehicleOfferDetailsViewModel : IMapFrom<Vehicle>
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string CoupeType { get; set; }

        public double FuelConsumption { get; set; }

        public int Horsepower { get; set; }

        public string RequiredLicenseCategory { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
