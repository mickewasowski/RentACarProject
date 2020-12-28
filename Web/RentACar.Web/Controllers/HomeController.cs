namespace RentACar.Web.Controllers
{
    using System.Diagnostics;

    using RentACar.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;
    using RentACar.Data.Models;
    using System.Threading.Tasks;
    using RentACar.Services.Data;

    public class HomeController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;

        public HomeController(UserManager<ApplicationUser> userManager, IUserService userService)
        {
            this.userManager = userManager;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            //var user = await this.userManager.GetUserAsync(this.User);
            //var userID = user.Id;

            //var result = await this.userService.GetUserInfoByID(userID);

            //var viewModel = new IndexViewModel { Updated = result };

            ////return this.View(viewModel);

            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
