namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class VehicleService : IVehicleService
    {
        private readonly IDeletableEntityRepository<Vehicle> vehicleRepository;

        public VehicleService(IDeletableEntityRepository<Vehicle> vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        public IEnumerable<T> GetAllVehicles<T>()
        {
            var vehicles = this.vehicleRepository.AllAsNoTracking()
                .OrderBy(x => x.Brand)
                .ThenBy(x => x.Model)
                .To<T>()
                .ToList();

            return vehicles;
        }

        public T GetById<T>(string id)
        {
            var vehicle = this.vehicleRepository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return vehicle;
        }
    }
}
