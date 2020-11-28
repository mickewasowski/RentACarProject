namespace RentACar.Web.ViewModels.Facility
{
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class FacilityDropDownViewModel : IMapFrom<Facility>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
