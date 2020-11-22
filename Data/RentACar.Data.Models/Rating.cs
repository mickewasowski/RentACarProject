// ReSharper disable VirtualMemberCallInConstructor
namespace RentACar.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Common.Models;

    public class Rating : BaseModel<string>, IDeletableEntity
    {
        public Rating()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int StarRating { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public string UserID { get; set; }

        public virtual ApplicationUser User { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsDeleted { get ; set ; }

        public DateTime? DeletedOn { get ; set ; }
    }
}