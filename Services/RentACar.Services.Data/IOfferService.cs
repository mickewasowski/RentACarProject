namespace RentACar.Services.Data
{
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.Offer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOfferService
    {
        Task<string> CreateOffer(string id, CreateOfferViewModel input, ApplicationUser user);
    }
}
