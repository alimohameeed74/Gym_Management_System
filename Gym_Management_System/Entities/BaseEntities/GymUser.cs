using Gym_Management_System.Entities.Enums;

namespace Gym_Management_System.Entities.BaseEntities
{
    public class GymUser:BaseClass
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }
}
