namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Models;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Vehicle;

    public class CommentController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICommentService commentService;

        public CommentController(UserManager<ApplicationUser> userManager, ICommentService commentService)
        {
            this.userManager = userManager;
            this.commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Comment(VehicleDetailsViewModel input)
        {
            var commentDetails = input.Comment;
            var user = await this.userManager.GetUserAsync(this.User);
            var userID = user.Id;

            await this.commentService.Comment(userID, commentDetails);


            //redirect to the same vehicle and list the comment
            return this.Redirect($"/Vehicle/VehicleDetails/{input.Comment.VehicleID}");
        }
    }
}
