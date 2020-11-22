namespace RentACar.Web.ViewModels.Vehicle
{
    using System.Linq;

    using AutoMapper;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class VehicleCardDetailsViewModel : IMapFrom<Vehicle>, IMapTo<Vehicle>, IHaveCustomMappings
    {
        public string Id { get; set; }
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Seats { get; set; }

        public FuelType FuelType { get; set; }

        public GearBoxType Gearbox { get; set; }

        public int Doors { get; set; }

        public decimal PricePerDay { get; set; }

        public string Picture { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Vehicle, VehicleCardDetailsViewModel>()
                .ForMember(x => x.Picture, options =>
                {
                    options.MapFrom(p => p.Pictures.FirstOrDefault().URL);
                });
        }
    }
}
