namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.City;

    public class CityService : ICityService
    {
        private readonly IDeletableEntityRepository<City> citiesRepository;

        public CityService(IDeletableEntityRepository<City> citiesRepository)
        {
            this.citiesRepository = citiesRepository;
        }

        public async Task<string> AddCity(AddCityViewModel input)
        {
            var city = new City
            {
                Name = input.Name,
            };

            await this.citiesRepository.AddAsync(city);
            await this.citiesRepository.SaveChangesAsync();

            return city.Id;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var result = this.citiesRepository.All().OrderBy(x => x.Name);

            return result.To<T>().ToList();
        }
    }
}
