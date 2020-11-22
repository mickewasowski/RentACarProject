namespace RentACar.Web.ViewModels.Vehicle
{
    using System.Collections.Generic;

    public class AllVehiclesViewModel
    {
        public IEnumerable<VehicleCardDetailsViewModel> Vehicles { get; set; }
    }
}
