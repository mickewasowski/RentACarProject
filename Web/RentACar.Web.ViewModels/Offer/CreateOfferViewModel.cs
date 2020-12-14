namespace RentACar.Web.ViewModels.Offer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class CreateOfferViewModel : IMapFrom<Offer>/*, IValidatableObject*/
    {
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public VehicleOfferDetailsViewModel VehicleDetails { get; set; }
    }
}
