namespace RentACar.Services.Data
{
    using RentACar.Web.ViewModels.User;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task EditProfile(EditMyProfileViewModel input, string userID);
    }
}
