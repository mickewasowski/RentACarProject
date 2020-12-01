namespace RentACar.Web.ViewModels.Image
{
    using AutoMapper;
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class CarImagesViewModel : IMapFrom<Picture>, IMapTo<Picture>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string URL { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Picture, CarImagesViewModel>()
                .ForMember(x => x.Id, options =>
                {
                    options.MapFrom(p => p.Id);
                })
                .ForMember(y => y.URL, opt =>
                {
                    opt.MapFrom(p => p.URL);
                });
        }
    }
}
