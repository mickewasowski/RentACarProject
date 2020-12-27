namespace RentACar.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class CommentController : Controller
    {
        [HttpPost]
        public IActionResult Comment()
        {
            return this.Redirect("/Vehicles/AllVehicles");
        }
    }
}
