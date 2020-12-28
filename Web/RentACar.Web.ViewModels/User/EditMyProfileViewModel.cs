namespace RentACar.Web.ViewModels.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using RentACar.Data.Models;
    using RentACar.Services.Mapping;

    public class EditMyProfileViewModel : IMapFrom<ApplicationUser>, IMapTo<ApplicationUser>
    {
        [MaxLength(40)]
        public string FullName { get; set; }

        [Range(18, 65, ErrorMessage ="You need to be at least 18 years old!")]
        public int Age { get; set; }

        public LicenseCategory LicenseCategories { get; set; }
    }
}
