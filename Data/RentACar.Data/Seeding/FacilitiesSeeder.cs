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

            var cities = dbContext.Cities.ToList();

            cities[0].Facilities.Add(new Facility
            {
                Name = "Sofia Facility",
                Address = "bul. Cherni Vrah 15",
                Contacts = "Asen Ignatov 0896784321",
                IsDeleted = false,
            });

            cities[1].Facilities.Add(new Facility
            {
                Name = "Veliko Tarnovo Facility",
                Address = "bul. Bulgaria 4",
                Contacts = "Ivan Petrov",
                IsDeleted = false,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
