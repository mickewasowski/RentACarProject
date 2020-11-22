namespace RentACar.Services.Data
{
    using System.Collections.Generic;

    public interface IVehicleService
    {
        IEnumerable<T> GetAllVehicles<T>();

        T GetById<T>(string id);
    }
}
