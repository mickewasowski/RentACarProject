namespace RentACar.Services.Data
{
    using RentACar.Web.ViewModels.Vehicle;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IVehicleService
    {
        IEnumerable<T> GetAllVehicles<T>();

        T GetById<T>(string id);

        Task<string> AddVehicle(AddVehicleViewModel input);
    }
}
