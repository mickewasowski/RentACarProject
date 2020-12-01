namespace RentACar.Web.ViewModels.City
{
    using AutoMapper;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class CityCardViewModel : IMapFrom<City>, IMapTo<City>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int FacilitiesCount { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<City, CityCardViewModel>()
                .ForMember(x => x.FacilitiesCount, options =>
                {
                    options.MapFrom(p => p.Facilities.Count);
                });
        }
    }
}
