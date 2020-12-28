namespace RentACar.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using RentACar.Data;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Web.Areas.Administration.Services;

    [Area("Administration")]
    public class VehiclesController : Controller
    {
        private readonly IDeletableEntityRepository<Vehicle> dataRepo;
        private readonly IRepository<Facility> facilityRepo;
        private readonly IVehicleAdminService vehicleAdminService;

        public VehiclesController(IDeletableEntityRepository<Vehicle> dataRepo, IRepository<Facility> facilityRepo, IVehicleAdminService vehicleAdminService)
        {
            this.dataRepo = dataRepo;
            this.facilityRepo = facilityRepo;
            this.vehicleAdminService = vehicleAdminService;
        }

        // GET: Administration/Vehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = this.dataRepo.All().Include(v => v.Facility);
            return this.View(await applicationDbContext.ToListAsync());
        }

        // GET: Administration/Vehicles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var vehicle = await this.dataRepo.All()
                .Include(v => v.Facility)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return this.NotFound();
            }

            return this.View(vehicle);
        }

        // GET: Administration/Vehicles/Create
        public IActionResult Create()
        {
            this.ViewData["FacilityId"] = new SelectList(this.facilityRepo.All(), "Id", "Id");
            return this.View();
        }

        // POST: Administration/Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Brand,Model,CoupeType,Seats,RequiredLicenseCategory,FuelType,Gearbox,Doors,YearOfManufacturing,FuelTankVolume,FuelConsumption,TrunkVolume,Horsepower,EngineVolume,IsBooked,PricePerDay,FacilityId,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Vehicle vehicle)
        {
            if (this.ModelState.IsValid)
            {
                await this.dataRepo.AddAsync(vehicle);
                await this.dataRepo.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            this.ViewData["FacilityId"] = new SelectList(this.facilityRepo.All(), "Id", "Id", vehicle.FacilityId);
            return this.View(vehicle);
        }

        // GET: Administration/Vehicles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var vehicle = await this.dataRepo.All().FirstOrDefaultAsync(x => x.Id == id);
            if (vehicle == null)
            {
                return this.NotFound();
            }

            this.ViewData["FacilityId"] = new SelectList(this.facilityRepo.All(), "Id", "Id", vehicle.FacilityId);
            return this.View(vehicle);
        }

        // POST: Administration/Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Brand,Model,CoupeType,Seats,RequiredLicenseCategory,FuelType,Gearbox,Doors,YearOfManufacturing,FuelTankVolume,FuelConsumption,TrunkVolume,Horsepower,EngineVolume,IsBooked,PricePerDay,FacilityId,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.dataRepo.Update(vehicle);
                    await this.dataRepo.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.VehicleExists(vehicle.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            this.ViewData["FacilityId"] = new SelectList(this.facilityRepo.All(), "Id", "Id", vehicle.FacilityId);
            return this.View(vehicle);
        }

        // GET: Administration/Vehicles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var vehicle = await this.dataRepo.All()
                .Include(v => v.Facility)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return this.NotFound();
            }

            return this.View(vehicle);
        }

        // POST: Administration/Vehicles/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var delete = await this.vehicleAdminService.Delete(id);

            //var vehicle = await this.dataRepo.All().FirstOrDefaultAsync(x => x.Id == id);
            //this.dataRepo.Delete(vehicle);
            //await this.dataRepo.SaveChangesAsync();

            if (delete == "Success!")
            {
                return this.Redirect("/Administration/Vehicles/Index");
            }
            else
            {
                return this.NotFound();
            }
        }

        private async Task<bool> VehicleExists(string id)
        {
            var result = await this.vehicleAdminService.VehicleExists(id);

            return result;
        }
    }
}
