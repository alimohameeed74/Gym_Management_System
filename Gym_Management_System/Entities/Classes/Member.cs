using Gym_Management_System.Entities.BaseEntities;

namespace Gym_Management_System.Entities.Classes
{
    public class Member:GymUser
    {
        public string? photo { get; set; }
        public DateOnly JoinDate { get; set; }
        public ICollection<Membership> Memberships { get; set; } = new HashSet<Membership>();

    }
}
