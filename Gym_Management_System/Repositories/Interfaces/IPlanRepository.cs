using Gym_Management_System.Entities.Classes;

namespace Gym_Management_System.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GellAll(CancellationToken ct = default);
        Task<Plan?> GetById(int id, CancellationToken ct = default);
    }
}
