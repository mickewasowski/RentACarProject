namespace RentACar.Web.ViewModels.Comment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CommentsDetailsViewModel
    {
        public string UserName { get; set; }

        public DateTime DateAdded { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
