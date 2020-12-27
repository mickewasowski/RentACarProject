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
    using RentACar.Web.ViewModels.Comment;

    public class CommentService : ICommentService
    {
        private readonly IDeletableEntityRepository<Comment> commentRepo;
        private readonly IRepository<ApplicationUser> usersRepo;

        public CommentService(IDeletableEntityRepository<Comment> commentRepo, IRepository<ApplicationUser> usersRepo)
        {
            this.commentRepo = commentRepo;
            this.usersRepo = usersRepo;
        }

        public async Task Comment(string userID, CommentInfoInputModel input)
        {
            if (userID == null)
            {
                throw new Exception("Invalid user!");
            }

            if (input.VehicleID == null)
            {
                throw new Exception("Invalid vehicle ID!");
            }

            if (input.Title == null || input.CommentDescription == null)
            {
                throw new Exception("You must input Title and Description!");
            }

            var comment = new Comment
            {
                VehicleID = input.VehicleID,
                UserID = userID,
                Title = input.Title,
                Description = input.CommentDescription,
                DateAdded = DateTime.UtcNow,
                IsDeleted = false,
            };

            await this.commentRepo.AddAsync(comment);
            await this.commentRepo.SaveChangesAsync();
        }

        public async Task<IEnumerable<CommentsDetailsViewModel>> Latest3VehicleComments(string vehicleID)
        {
            var comments = await this.commentRepo.All().Where(x => x.VehicleID == vehicleID).OrderByDescending(x => x.DateAdded).Take(3).ToListAsync();

            var result = new List<CommentsDetailsViewModel>();

            foreach (var com in comments)
            {

                var user = await this.usersRepo.All().FirstOrDefaultAsync(x => x.Id == com.UserID);

                var mapped = new CommentsDetailsViewModel
                {
                    DateAdded = com.DateAdded,
                    UserName = user.UserName,
                    Description = com.Description,
                    Title = com.Title,
                };

                result.Add(mapped);
            }

            return result;
        }
    }
}
