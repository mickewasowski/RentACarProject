namespace RentACar.Web.Areas.Administration.Services
{
    using Microsoft.EntityFrameworkCore;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class VehicleAdminService : IVehicleAdminService
    {
        private readonly IDeletableEntityRepository<Vehicle> vehicleRepo;

        public VehicleAdminService(IDeletableEntityRepository<Vehicle> vehicleRepo)
        {
            this.vehicleRepo = vehicleRepo;
        }

        public async Task<string> Delete(string id)
        {
            var vehicle = await this.vehicleRepo.All().FirstOrDefaultAsync(x => x.Id == id);

            if (vehicle == null)
            {
                throw new Exception("No vehicle found!");
            }

            vehicle.IsDeleted = true;

            await this.vehicleRepo.SaveChangesAsync();

            return "Success!";
        }

        public async Task<bool> VehicleExists(string id)
        {
            var vehicle = await this.vehicleRepo.All().FirstOrDefaultAsync(x => x.Id == id);

            if (vehicle == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
