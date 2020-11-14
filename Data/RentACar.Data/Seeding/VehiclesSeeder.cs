namespace RentACar.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using RentACar.Data.Models;

    public class VehiclesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Vehicles.Any())
            {
                return;
            }

            var facilities = dbContext.Facilities.ToList();

            facilities[0].Vehicles.Add(new Vehicle
            {
                Brand = "Renault",
                Model = "Laguna",
                CoupeType = CoupeType.Coupe,
                Seats = 5,
                RequiredLicenseCategory = 'B',
                FuelType = FuelType.Diesel,
                Gearbox = GearBoxType.Automatic,
                Doors = 5,
                YearOfManufacturing = 2015,
                FuelTankVolume = 66,
                FuelConsumption = 7,
                TrunkVolume = 423,
                Horsepower = 150,
                EngineVolume = 2,
                IsBooked = false,
                PricePerDay = 30,
                IsDeleted = false,
            });
            facilities[0].Vehicles.FirstOrDefault().Pictures.Add(new Picture
            {
                URL = "https://fuse-box.info/wp-content/uploads/2018/03/Renault-Laguna-III-2007-2015.jpg",
                IsDeleted = false,
            });

            facilities[1].Vehicles.Add(new Vehicle
            {
                Brand = "Fiat",
                Model = "Tipo",
                CoupeType = CoupeType.Sedan,
                Seats = 5,
                RequiredLicenseCategory = 'B',
                FuelType = FuelType.Gasoline,
                Gearbox = GearBoxType.Manual,
                Doors = 5,
                YearOfManufacturing = 2015,
                FuelTankVolume = 45,
                FuelConsumption = 5.7,
                TrunkVolume = 520,
                Horsepower = 95,
                EngineVolume = 1.4,
                IsBooked = false,
                PricePerDay = 20,
                IsDeleted = false,
            });
            facilities[1].Vehicles.FirstOrDefault().Pictures.Add(new Picture
            {
                URL = "https://www.elmasria-auto.com/files/52440_1579166082.png",
                IsDeleted = false,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
