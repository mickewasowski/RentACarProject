namespace RentACar.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Vehicle;
    using System.Threading.Tasks;

    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        public IActionResult AddVehicle()
        {
            return this.View();
        }

        public IActionResult AllVehicles()
        {
            var allVehicles = this.vehicleService.GetAllVehicles<VehicleCardDetailsViewModel>();

            var model = new AllVehiclesViewModel { Vehicles = allVehicles };

            return this.View(model);
        }

        public IActionResult Details(string id)
        {
            var vehicle = this.vehicleService.GetById<VehicleDetailsViewModel>(id);

            return this.View(vehicle);
        }
    }
}
