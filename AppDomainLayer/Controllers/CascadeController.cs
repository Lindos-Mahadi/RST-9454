using AppDomainLayer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppDomainLayer.Controllers
{
    public class CascadeController : Controller
    {
        private readonly ApplicationDbContext context;

        public CascadeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<JsonResult> CountryList()
        {
            var countryList = await context.Country.ToListAsync();
            return new JsonResult(countryList);
        }

        public async Task<JsonResult> StateList(int id)
        {
            var stateList = await context.State.Where(s => s.Country.Id == id).ToListAsync();
            return new JsonResult(stateList);
        }

        public async Task<JsonResult> CityList(int id)
        {
            var cityList = await context.City.Where(c => c.State.Id == id).ToListAsync();
            return new JsonResult(cityList);
        }

        public IActionResult CascadeDropdown()
        {
            return View();
        }
    }
}
