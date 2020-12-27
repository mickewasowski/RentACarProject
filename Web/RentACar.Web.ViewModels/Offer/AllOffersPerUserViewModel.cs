namespace RentACar.Web.ViewModels.Offer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AllOffersPerUserViewModel
    {
        public IEnumerable<OfferCardDetailsViewModel> Offers { get; set; }
    }
}
