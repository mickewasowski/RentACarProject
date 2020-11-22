namespace RentACar.Services.Data
{
    using System;

    using CloudinaryDotNet;
    using Microsoft.Extensions.Configuration;

    public class CloudinaryService : ICloudinaryService
    {
        private IConfiguration configuration;

        public CloudinaryService(IConfiguration iConfig)
        {
            this.configuration = iConfig;
        }

        public void UploadImage()
        {
            throw new NotImplementedException();
        }

        public void AuthenticateAccount()
        {
            // CLOUDINARY_URL=cloudinary://265295315814647:6K5JSLtUS8smA9YpM4rKA1Q1utU@mickewasowski

            Account account = new Account(
                this.configuration["Cloudinary:CloudName"],
                this.configuration["Cloudinary:APIKey"],
                this.configuration["Cloudinary:APISecret"]);

            Cloudinary cloudinary = new Cloudinary(account);
        }

    }
}
