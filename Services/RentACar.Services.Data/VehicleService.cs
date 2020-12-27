namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.Image;
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

        public async Task BookVehicle(string id)
        {
            var vehicle = this.vehicleRepository.All().FirstOrDefault(x => x.Id == id);

            vehicle.IsBooked = true;

            await this.vehicleRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllPicturesById<T>(string id)
        {
            var pictures = this.vehicleRepository.AllAsNoTracking()
                .Where(x => x.Id == id).Select(z => z.Pictures).To<T>().ToList();

            return pictures;
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

        public VehicleDetailsViewModel GetById(string id)
        {
            var vehicle = this.vehicleRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();

            var vehicleImages = this.vehicleRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => x.Pictures.ToList())
                .FirstOrDefault();

            var imagesList = new List<CarImagesViewModel>();

            foreach (var pic in vehicleImages)
            {
                var converted = new CarImagesViewModel
                {
                    Id = pic.Id,
                    URL = pic.URL,
                };

                imagesList.Add(converted);
            }

            var mapped = new VehicleDetailsViewModel
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                CoupeType = vehicle.CoupeType,
                Seats = vehicle.Seats,
                RequiredLicenseCategory = vehicle.RequiredLicenseCategory,
                FuelType = vehicle.FuelType,
                Gearbox = vehicle.Gearbox,
                Doors = vehicle.Doors,
                YearOfManufacturing = vehicle.YearOfManufacturing,
                FuelTankVolume = vehicle.FuelTankVolume,
                FuelConsumption = vehicle.FuelConsumption,
                TrunkVolume = vehicle.TrunkVolume,
                Horsepower = vehicle.Horsepower,
                EngineVolume = vehicle.EngineVolume,
                PricePerDay = vehicle.PricePerDay,
                IsBooked = vehicle.IsBooked,
                Images = imagesList,
            };

            return mapped;
        }
    }
}
