using Gym_Management_System.Contexts;
using Gym_Management_System.Entities.Classes;
using Gym_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Gym_Management_System.Repositories.Classes
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly AppDbContext _dbContext;

        public MembershipRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AnyAsync(Expression<Func<Membership, bool>> expression, CancellationToken ct = default)
        {
            return await _dbContext.Memberships.AnyAsync(expression, ct);
        }
    }
}
