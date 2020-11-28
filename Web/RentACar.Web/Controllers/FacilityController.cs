namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Facility;

    public class FacilityController : Controller
    {
        private readonly IFacilityService facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            this.facilityService = facilityService;
        }

        public IActionResult AddFacility()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFacility(AddNewFacilityViewModel input)
        {
            var facilityID = await this.facilityService.AddFacility(input);

            return this.Redirect("AddFacility");
        }
    }
}
