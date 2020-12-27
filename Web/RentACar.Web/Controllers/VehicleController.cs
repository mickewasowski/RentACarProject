namespace RentACar.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Facility;
    using RentACar.Web.ViewModels.Image;
    using RentACar.Web.ViewModels.Vehicle;

    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly ICloudinaryService cloudinaryService;
        private readonly IFacilityService facilityService;
        private readonly ICommentService commentService;

        public VehicleController(IVehicleService vehicleService, ICloudinaryService cloudinaryService, IFacilityService facilityService, ICommentService commentService)
        {
            this.vehicleService = vehicleService;
            this.cloudinaryService = cloudinaryService;
            this.facilityService = facilityService;
            this.commentService = commentService;
        }

        [Authorize]
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
        //[Authorize]
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

        public async Task<IActionResult> VehicleDetails(string id)
        {
            var vehicle = this.vehicleService.GetById(id);

            var comments = await this.commentService.Latest3VehicleComments(id);

            vehicle.LatestComments = comments;

            return this.View(vehicle);
        }
    }
}
