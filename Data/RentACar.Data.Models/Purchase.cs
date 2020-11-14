// ReSharper disable VirtualMemberCallInConstructor
namespace RentACar.Data.Models
{
    using System;

    using RentACar.Data.Common.Models;

    public class Purchase : BaseModel<string>, IDeletableEntity
    {
        public Purchase()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string VehicleID { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public string OfferID { get; set; }

        public virtual Offer Offer { get; set; }

        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}