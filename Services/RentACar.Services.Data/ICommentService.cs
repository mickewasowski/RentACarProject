namespace RentACar.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using RentACar.Web.ViewModels.Comment;

    public interface ICommentService
    {
        Task Comment(string userID, CommentInfoInputModel input);

        Task<IEnumerable<CommentsDetailsViewModel>> Latest3VehicleComments(string vehicleID);
    }
}
