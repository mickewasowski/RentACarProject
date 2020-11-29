namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.City;

    public class CityController : Controller
    {
        private readonly ICityService cityService;

        public CityController(ICityService cityService)
        {
            this.cityService = cityService;
        }

        public IActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(AddCityViewModel input)
        {
            var cityID = await this.cityService.AddCity(input);

            return this.View();
        }
    }
}
