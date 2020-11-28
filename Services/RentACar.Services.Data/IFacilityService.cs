namespace RentACar.Services.Data
{
    using RentACar.Web.ViewModels.Facility;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IFacilityService
    {
        IEnumerable<T> GetAll<T>();

        Task<string> AddFacility(AddNewFacilityViewModel input);
    }
}
