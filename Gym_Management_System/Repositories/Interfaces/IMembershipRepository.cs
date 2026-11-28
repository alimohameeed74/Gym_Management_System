using Gym_Management_System.Entities.Classes;
using System.Linq.Expressions;

namespace Gym_Management_System.Repositories.Interfaces
{
    public interface IMembershipRepository
    {
        Task<bool> AnyAsync(Expression<Func<Membership, bool>> expression, CancellationToken ct = default);
    }
}
