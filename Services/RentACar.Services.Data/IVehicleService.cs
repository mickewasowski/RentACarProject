namespace RentACar.Services.Data
{
    using RentACar.Web.ViewModels.Vehicle;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IVehicleService
    {
        IEnumerable<T> GetAllVehicles<T>();

        VehicleDetailsViewModel GetById(string id);

        IEnumerable<T> GetAllPicturesById<T>(string id);

        Task<string> AddVehicle(AddVehicleViewModel input);
    }
}
