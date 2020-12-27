namespace RentACar.Web.ViewModels.Offer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class OfferCardDetailsViewModel : IMapFrom<Offer>
    {
        public string OfferId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal TotalPrice { get; set; }

        public VehicleOfferDetailsViewModel VehicleDetails { get; set; }
    }
}
