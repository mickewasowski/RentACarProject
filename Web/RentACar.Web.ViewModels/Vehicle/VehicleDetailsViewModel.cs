﻿namespace RentACar.Web.ViewModels.Vehicle
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;
    using RentACar.Web.ViewModels.Image;

    public class VehicleDetailsViewModel /*: IMapFrom<Vehicle>*/
    {
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public CoupeType CoupeType { get; set; }

        public int Seats { get; set; }

        public LicenseCategory RequiredLicenseCategory { get; set; }

        public FuelType FuelType { get; set; }

        public GearBoxType Gearbox { get; set; }

        public int Doors { get; set; }

        public int YearOfManufacturing { get; set; }

        public int FuelTankVolume { get; set; }

        public double FuelConsumption { get; set; }

        public double TrunkVolume { get; set; }

        public int Horsepower { get; set; }

        public double EngineVolume { get; set; }

        public decimal PricePerDay { get; set; }

        //public IEnumerable<Rating> Ratings { get; set; }

        //public GalleryViewModel Images { get; set; }

        public IEnumerable<CarImagesViewModel> Images { get; set; }

        //public void CreateMappings(IProfileExpression configuration)
        //{
        //    //configuration.CreateMap<Vehicle, VehicleDetailsViewModel>()
        //    //    .ForMember(x => x.Picture, options =>
        //    //    {
        //    //        options.MapFrom(p => p.Pictures.FirstOrDefault().URL);
        //    //    });

        //    //configuration.CreateMap<Picture, CarImagesViewModel>()
        //    //    .ForMember(x => x.URL, options =>
        //    //    {
        //    //        options.MapFrom(p => p.URL);
        //    //    })
        //    //    .ForMember(y => y.Id, opt =>
        //    //    {
        //    //        opt.MapFrom(p => p.Id);
        //    //    });
        //}
    }
}
