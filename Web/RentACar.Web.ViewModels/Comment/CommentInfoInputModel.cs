namespace RentACar.Web.ViewModels.Comment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CommentInfoInputModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "The title must be at least 5 characters long!")]
        [MaxLength(30, ErrorMessage = "The title must be no more than 30 characters long!")]
        public string Title { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "The description must be at least 5 characters long!")]
        [MaxLength(80, ErrorMessage = "The description must be no longer than 80 characters!")]
        public string CommentDescription { get; set; }

        public string VehicleID { get; set; }
    }
}
