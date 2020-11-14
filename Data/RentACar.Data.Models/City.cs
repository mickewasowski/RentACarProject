namespace RentACar.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Common.Models;

    public class City : BaseModel<string>, IDeletableEntity
    {
        public City()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Facilities = new HashSet<Facility>();
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }

        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
