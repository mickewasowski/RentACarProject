namespace RentACar.Web.ViewModels.City
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class CityDropDownViewModel : IMapFrom<City>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
