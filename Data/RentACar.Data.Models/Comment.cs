// ReSharper disable VirtualMemberCallInConstructor
namespace RentACar.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Common.Models;

    public class Comment : BaseModel<string>, IDeletableEntity
    {
        public Comment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public string UserID { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string VehicleID { get; set; }

        public Vehicle Vehicle { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsDeleted { get ; set ; }

        public DateTime? DeletedOn { get ; set ; }
    }
}