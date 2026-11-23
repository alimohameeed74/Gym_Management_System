using Gym_Management_System.Entities.BaseEntities;
using Gym_Management_System.Entities.Enums;

namespace Gym_Management_System.Entities.Classes
{
    public class Trainer:GymUser
    {
        public DateOnly HireDate { get; set; }
        public Specialization Specialization { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();

    }
}
