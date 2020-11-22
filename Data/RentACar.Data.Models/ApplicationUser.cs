// ReSharper disable VirtualMemberCallInConstructor
namespace RentACar.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using RentACar.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.PurchaseHistory = new HashSet<Purchase>();
            this.Ratings = new HashSet<Rating>();
        }

        //[Required]
        [MaxLength(40)]
        public string FullName { get; set; }

        [Range(18, 65, ErrorMessage ="Please enter a valid age number!")]
        public int? Age { get; set; }

        public string LicenseCategories { get; set; } // comma separated list of license categories

        public virtual ICollection<Purchase> PurchaseHistory { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
