namespace RentACar.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.Offer;

    public class OfferService : IOfferService
    {
        private readonly IDeletableEntityRepository<Offer> offerRepository;
        private readonly IRepository<Vehicle> vehicleRepository;

        public OfferService(IDeletableEntityRepository<Offer> offerRepository, IRepository<Vehicle> vehicleRepository)
        {
            this.offerRepository = offerRepository;
            this.vehicleRepository = vehicleRepository;
        }

        public async Task<string> CreateOffer(string id, CreateOfferViewModel input, ApplicationUser user)
        {
            var vehicleID = id;
            var vehicle = await this.vehicleRepository.AllAsNoTracking().Where(x => x.Id == vehicleID).FirstOrDefaultAsync();
            var vehicleRequiredLicense = vehicle.RequiredLicenseCategory.ToString();

            var userLicense = user.LicenseCategories.ToString();
            var userID = user.Id;

            int totalDays = (input.EndDate - input.StartDate).Days;

            if (!(DateTime.Compare(input.StartDate, input.EndDate) < 0))
            {
                throw new Exception("Start date must be earlier than the end date!");
            }

            if (userLicense != vehicleRequiredLicense)
            {
                throw new Exception($"You need a valid license of type {vehicleRequiredLicense}");
            }

            var totalPrice = totalDays * vehicle.PricePerDay;

            var offer = new Offer{
                VehicleID = vehicleID,
                StartDate = input.StartDate,
                EndDate = input.EndDate,
                TotalDays = totalDays,
                UserID = userID,
                IsDeleted = false,
                Price = totalPrice,
            };

            await this.offerRepository.AddAsync(offer);
            await this.offerRepository.SaveChangesAsync();

            return offer.Id;
        }
    }
}
