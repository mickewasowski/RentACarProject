namespace RentACar.Web.Areas.Administration.Services
{
    using RentACar.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IVehicleAdminService
    {

        Task<string> Delete(string id);

        Task<bool> VehicleExists(string id);
    }
}
