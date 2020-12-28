namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Models;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.User;

    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(IUserService userService, UserManager<ApplicationUser> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }

        public IActionResult EditMyProfile()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditMyProfile(EditMyProfileViewModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var userID = user.Id;

            await this.userService.EditProfile(input, userID);

            return this.Redirect("/");
        }
    }
}
