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

        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}