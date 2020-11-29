namespace RentACar.Web.ViewModels.Image
{
    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class CarImagesViewModel : IMapFrom<Picture>
    {
        public string Id { get; set; }

        public string URL { get; set; }
    }
}
