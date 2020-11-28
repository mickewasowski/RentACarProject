namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;

    public class CloudinaryService : ICloudinaryService
    {
        private IConfiguration configuration;

        public CloudinaryService(IConfiguration iConfig)
        {
            this.configuration = iConfig;
        }

        public async Task<ICollection<string>> UploadImage(ICollection<IFormFile> pictures)
        {
            Account account = new Account(
                this.configuration["Cloudinary:CloudName"],
                this.configuration["Cloudinary:APIKey"],
                this.configuration["Cloudinary:APISecret"]);

            Cloudinary cloudinary = new Cloudinary(account);

            var imageURLs = new List<string>();

            foreach (var pic in pictures)
            {
                var convertedImage = new byte[0];

                using (var ms = new MemoryStream())
                {
                    pic.CopyTo(ms);
                    var fileBytes = ms.ToArray();

                    convertedImage = fileBytes;
                }

                Stream stream = new MemoryStream(convertedImage);

                var uploadImage = new ImageUploadParams()
                {
                    File = new FileDescription(pic.FileName, stream),
                };

                var uploadResult = await cloudinary.UploadAsync(uploadImage);

                var imageURL = uploadResult.Uri.OriginalString;

                imageURLs.Add(imageURL);
            }

            return imageURLs;
        }
    }
}
