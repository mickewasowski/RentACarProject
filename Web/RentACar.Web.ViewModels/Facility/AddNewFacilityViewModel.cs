namespace RentACar.Web.ViewModels.Facility
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

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

        [Display(Name = "City")]
        public Cities CityName { get; set; }

        //public IEnumerable<CityDropDownViewModel> Cities { get; set; }
    }
}
