using Gym_Management_System.Entities.BaseEntities;

namespace Gym_Management_System.Entities.Classes
{
    public class Session:BaseClass
    {
        public int Capacity { get; set; }
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = null!;
    }
}
