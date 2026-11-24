using Gym_Management_System.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Controllers
{
    public class PlansController : Controller
    {
        private AppDbContext dbContext = new AppDbContext(); 
        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
