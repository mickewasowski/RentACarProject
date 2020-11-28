namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.Vehicle;

    public class VehicleService : IVehicleService
    {
        private readonly IDeletableEntityRepository<Vehicle> vehicleRepository;
        private readonly ICloudinaryService cloudinaryService;

        public VehicleService(IDeletableEntityRepository<Vehicle> vehicleRepository, ICloudinaryService cloudinaryService)
        {
            this.vehicleRepository = vehicleRepository;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<string> AddVehicle(AddVehicleViewModel input)
        {
            var pictures = input.Pictures.ToList();
            var cloudinaryResult = await this.cloudinaryService.UploadImage(pictures);

            var vehicle = new Vehicle
            {
                FacilityId = input.FacilityId,
                Brand = input.Brand,
                Model = input.Model,
                CoupeType = input.CoupeType,
                Seats = input.Seats,
                RequiredLicenseCategory = input.RequiredLicenseCategory,
                FuelType = input.FuelType,
                Gearbox = input.Gearbox,
                Doors = input.Doors,
                YearOfManufacturing = input.YearOfManufacturing,
                FuelTankVolume = input.FuelTankVolume,
                FuelConsumption = input.FuelConsumption,
                TrunkVolume = input.TrunkVolume,
                Horsepower = input.Horsepower,
                EngineVolume = input.EngineVolume,
                IsBooked = false,
                PricePerDay = input.PricePerDay,
            };

            foreach (var picURL in cloudinaryResult)
            {
                vehicle.Pictures.Add(new Picture
                {
                    URL = picURL,
                });
            }

            await this.vehicleRepository.AddAsync(vehicle);
            await this.vehicleRepository.SaveChangesAsync();

            var vehicleID = vehicle.Id;

            return vehicleID;
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
            var vehicle = this.vehicleRepository.AllAsNoTracking().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return vehicle;
        }
    }
}
