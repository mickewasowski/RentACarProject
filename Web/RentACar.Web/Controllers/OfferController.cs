namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Models;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Offer;

    public class OfferController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IOfferService offerService;

        public OfferController(IVehicleService vehicleService, UserManager<ApplicationUser> userManager, IOfferService offerService)
        {
            this.vehicleService = vehicleService;
            this.userManager = userManager;
            this.offerService = offerService;
        }

        public IActionResult CreateOffer(string id)
        {
            var vehicleInfo = this.vehicleService.GetById(id);

            var details = new VehicleOfferDetailsViewModel
            {
                Brand = vehicleInfo.Brand,
                Model = vehicleInfo.Model,
                CoupeType = vehicleInfo.CoupeType.ToString(),
                FuelConsumption = vehicleInfo.FuelConsumption,
                RequiredLicenseCategory = vehicleInfo.RequiredLicenseCategory.ToString(),
                Horsepower = vehicleInfo.Horsepower,
                PricePerDay = vehicleInfo.PricePerDay,
            };

            var viewModel = new CreateOfferViewModel();
            viewModel.VehicleDetails = details;

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffer(string id, CreateOfferViewModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            var offerID = await this.offerService.CreateOffer(id, input, user);

            if (offerID != null)
            {
                await this.vehicleService.BookVehicle(id);
            }

            // redirect to MyOffers menu

            return this.Redirect("/Vehicle/AllVehicles");
        }

        public IActionResult AllOffersPerUser()
        {
            return this.View();
        }
    }
}
