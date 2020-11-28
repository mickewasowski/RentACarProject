namespace RentACar.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentACar.Data.Common.Models;

    public class Facility : BaseModel<string>, IDeletableEntity
    {
        public Facility()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Vehicles = new HashSet<Vehicle>();
        }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        public string Address { get; set; }

        [Required]
        [MaxLength(60)]
        public string Contacts { get; set; } // should it be a single string ??

        public string CityId { get; set; }
        public City City { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public bool IsDeleted { get ; set ; }

        public DateTime? DeletedOn { get ; set ; }
    }
}