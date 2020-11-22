namespace RentACar.Data.Models
{
    using System;

    using RentACar.Data.Common.Models;

    public class Offer : BaseModel<string>, IDeletableEntity
    {
        public Offer()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string VehicleID { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public PackageType PackageType { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate{ get; set; }

        public DateTime EndDate { get; set; }

        public string UserID { get; set; }

        public virtual ApplicationUser User { get; set; }  // is this the creator or the customer ??

        // Deletable Entity
        public bool IsDeleted { get ; set ; }

        public DateTime? DeletedOn { get ; set ; }
    }
}
