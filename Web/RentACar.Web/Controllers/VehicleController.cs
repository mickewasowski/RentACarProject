namespace RentACar.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Facility;
    using RentACar.Web.ViewModels.Vehicle;

    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly ICloudinaryService cloudinaryService;
        private readonly IFacilityService facilityService;

        public VehicleController(IVehicleService vehicleService, ICloudinaryService cloudinaryService, IFacilityService facilityService)
        {
            this.vehicleService = vehicleService;
            this.cloudinaryService = cloudinaryService;
            this.facilityService = facilityService;
        }

        public IActionResult AddVehicle()
        {
            var facilities = this.facilityService.GetAll<FacilityDropDownViewModel>();
            var viewModel = new AddVehicleViewModel
            {
                Facilities = facilities,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle(AddVehicleViewModel input)
        {
            var vehicleID = await this.vehicleService.AddVehicle(input);

            return this.Redirect($"VehicleDetails/{vehicleID}");
        }

        public IActionResult AllVehicles()
        {
            var allVehicles = this.vehicleService.GetAllVehicles<VehicleCardDetailsViewModel>();

            var model = new AllVehiclesViewModel { Vehicles = allVehicles };

            return this.View(model);
        }

        public IActionResult VehicleDetails(string id)
        {
            var vehicle = this.vehicleService.GetById<VehicleDetailsViewModel>(id);

            return this.View(vehicle);
        }
    }
}
