using Gym_Management_System.Contexts;
using Gym_Management_System.Entities.Classes;
using Gym_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly AppDbContext _dbContext;

        public PlanRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Plan>> GellAll(CancellationToken ct = default)
        {
            return await _dbContext.Plans.AsNoTracking().ToListAsync();
        }

        public async Task<Plan?> GetById(int id, CancellationToken ct = default)
        {
            return await _dbContext.Plans.FindAsync([id],cancellationToken:ct);
        }
    }
}
