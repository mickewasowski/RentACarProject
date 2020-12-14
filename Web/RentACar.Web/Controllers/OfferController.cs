namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Offer;

    public class OfferController : Controller
    {
        private readonly IVehicleService vehicleService;

        public OfferController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }
        public IActionResult CreateOffer(string id)
        {
            //var vehiclePricePerDay = this.vehicleService.GetById(id).PricePerDay;

            //var viewModel = new CreateOfferViewModel { PricePerDay = vehiclePricePerDay };

            // return VehicleOfferDetailsViewModel

            return this.View();
        }

        [HttpPost]
        public IActionResult CreateOffer(string id, CreateOfferViewModel input)
        {
           // save in the offer the id of the vehicle

            // redirect to MyOffers menu

            return this.Redirect("/Vehicle/AllVehicles");
        }
    }
}
