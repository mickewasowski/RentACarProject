namespace RentACar.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using RentACar.Data.Common.Models;

    public class Picture : BaseModel<string>, IDeletableEntity
    {
        public Picture()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string URL { get; set; }

        public bool IsDeleted { get ; set; }

        public DateTime? DeletedOn { get ; set ; }
    }
}