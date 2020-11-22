namespace RentACar.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Vehicle;
    using System.Linq;
    using System.Threading.Tasks;

    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly IDeletableEntityRepository<Vehicle> vehicleRepository;

        public VehicleController(IVehicleService vehicleService, IDeletableEntityRepository<Vehicle> vehicleRepository)
        {
            this.vehicleService = vehicleService;
            this.vehicleRepository = vehicleRepository;
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

        public IActionResult VehicleDetails(string id)
        {
            //test comment

            var vehicle = this.vehicleService.GetById<VehicleDetailsViewModel>(id);

            return this.View(vehicle);
        }
    }
}
