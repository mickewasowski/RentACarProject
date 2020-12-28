namespace RentACar.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepo;

        public UserService(IDeletableEntityRepository<ApplicationUser> userRepo)
        {
            this.userRepo = userRepo;
        }

        public async Task EditProfile(EditMyProfileViewModel input, string userID)
        {
            var user = await this.userRepo.All().FirstOrDefaultAsync(x => x.Id == userID);

            user.FullName = input.FullName;
            user.Age = input.Age;
            user.LicenseCategories = input.LicenseCategories;

            await this.userRepo.SaveChangesAsync();
        }

        //public async Task<bool> GetUserInfoByID(string userID)
        //{
        //    var user = await this.userRepo.All().FirstOrDefaultAsync(x => x.Id == userID);

        //    if (user.FullName == null || user.Age == null || user.LicenseCategories == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
