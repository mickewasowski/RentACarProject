namespace RentACar.Services.Data
{
    using RentACar.Web.ViewModels.City;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICityService
    {
        IEnumerable<T> GetAll<T>();

        Task<string> AddCity(AddCityViewModel input);
    }
}
