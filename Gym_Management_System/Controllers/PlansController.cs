using Gym_Management_System.Contexts;
using Gym_Management_System.Repositories.Classes;
using Gym_Management_System.Repositories.Interfaces;
using Gym_Management_System.ViewModels.Plans;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Controllers
{
    public class PlansController : Controller
    {
        private readonly IPlanRepository _planRepository;
        private readonly IMembershipRepository _membershipRepository;

        public PlansController(IPlanRepository planRepository, IMembershipRepository membershipRepository)
        {
            _planRepository = planRepository;
           _membershipRepository = membershipRepository;
        }
        public async Task<IActionResult> Index()
        {
            var plans = await _planRepository.GellAll();
            var showedPlans = plans.Select(p => new PlanViewModel
            {
                Id = p.Id,
                Description = p.Description,
                DurationDays = p.DurationDays,
                IsActive = p.IsActive,
                Name = p.Name,
                Price= p.Price
            });
            return View(showedPlans);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id, CancellationToken ct = default)
        {
            var plan = await _planRepository.GetById(id, ct);
            if(plan is null || !plan.IsActive)
            {
                TempData["ErrorMessage"] = "Plan not found or is currently inactive.";
                return RedirectToAction(nameof(Index));
            }
            var isPlanHasMembers = await _membershipRepository.AnyAsync(m=> 
            m.PlanId == id && DateTime.Now < m.EndDate
            , ct);
            if (isPlanHasMembers)
            {
                TempData["ErrorMessage"] = "Can't edit this plan.";
                return RedirectToAction(nameof(Index));
            }
            var _plan = new EditViewModel
            {
                Description = plan.Description,
                DurationDays = plan.DurationDays,
                Name = plan.Name,
                Price=plan.Price
            };
            return View(_plan);

        }
    }
}
