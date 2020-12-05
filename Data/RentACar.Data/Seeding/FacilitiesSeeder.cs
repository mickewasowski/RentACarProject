namespace RentACar.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using RentACar.Data.Models;

    public class FacilitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Facilities.Any())
            {
                return;
            }

            dbContext.Facilities.Add(new Facility
            {
                Name = "Sofia Facility",
                Address = "bul. Cherni Vrah 15",
                Contacts = "Asen Ignatov 0896784321",
                CityName = Cities.Sofia,
                IsDeleted = false,
            });

            dbContext.Facilities.Add(new Facility
            {
                Name = "Veliko Tarnovo Facility",
                Address = "bul. Bulgaria 4",
                Contacts = "Ivan Petrov",
                CityName = Cities.VelikoTarnovo,
                IsDeleted = false,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
