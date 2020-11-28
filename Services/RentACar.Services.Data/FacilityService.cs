namespace RentACar.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.Facility;

    public class FacilityService : IFacilityService
    {
        private readonly IDeletableEntityRepository<Facility> facilitiesRepository;

        public FacilityService(IDeletableEntityRepository<Facility> facilitiesRepository)
        {
            this.facilitiesRepository = facilitiesRepository;
        }

        public async Task<string> AddFacility(AddNewFacilityViewModel input)
        {
            var facility = new Facility
            {
                Name = input.Name,
                Address = input.Address,
                Contacts = input.Contacts,
            };

            await this.facilitiesRepository.AddAsync(facility);
            await this.facilitiesRepository.SaveChangesAsync();

            return facility.Id;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var result = this.facilitiesRepository.All().OrderBy(x => x.Name);

            return result.To<T>().ToList();
        }
    }
}
