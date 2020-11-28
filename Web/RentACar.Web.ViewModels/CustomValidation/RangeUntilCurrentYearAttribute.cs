namespace RentACar.Web.ViewModels.CustomValidation
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RangeUntilCurrentYearAttribute : RangeAttribute
    {
        public RangeUntilCurrentYearAttribute(int minimum)
            : base(minimum, DateTime.Now.Year)
        {
        }
    }
}
