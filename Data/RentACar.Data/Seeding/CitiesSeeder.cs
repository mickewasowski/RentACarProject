namespace RentACar.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using RentACar.Data.Models;

    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            await dbContext.Cities.AddAsync(new City
            {
                Name = "Sofia",
                IsDeleted = false,
            });

            await dbContext.Cities.AddAsync(new City
            {
                Name = "Veliko Tarnovo",
                IsDeleted = false,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
