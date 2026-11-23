namespace Gym_Management_System.Entities.BaseEntities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime? UpdatedAt { get; set; }

    }
}
