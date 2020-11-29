namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.City;
    using RentACar.Web.ViewModels.Facility;

    public class FacilityController : Controller
    {
        private readonly IFacilityService facilityService;
        private readonly ICityService cityService;

        public FacilityController(IFacilityService facilityService, ICityService cityService)
        {
            this.facilityService = facilityService;
            this.cityService = cityService;
        }

        public IActionResult AddFacility()
        {
            var cities = this.cityService.GetAll<CityDropDownViewModel>();
            var viewModel = new AddNewFacilityViewModel
            {
                Cities = cities,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddFacility(AddNewFacilityViewModel input)
        {
            var facilityID = await this.facilityService.AddFacility(input);

            return this.Redirect("AddFacility");
        }
    }
}
