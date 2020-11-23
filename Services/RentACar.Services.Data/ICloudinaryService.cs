namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface ICloudinaryService
    {
        Task<ICollection<string>> UploadImage(ICollection<IFormFile> pictures);
    }
}
