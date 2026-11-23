using Gym_Management_System.Entities.BaseEntities;

namespace Gym_Management_System.Entities.Classes
{
    public class Plan:BaseClass
    {

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Membership> Memberships { get; set; } = new HashSet<Membership>();

    }
}
