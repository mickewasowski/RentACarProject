namespace RentACar.Web.ViewModels.Facility
{
    using RentACar.Services.Mapping;
    using System.ComponentModel.DataAnnotations;
    using RentACar.Data.Models;

    public class AddNewFacilityViewModel : IMapFrom<Facility>
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        public string Address { get; set; }

        [Required]
        [MaxLength(60)]
        public string Contacts { get; set; } // should it be a single string ??
    }
}
