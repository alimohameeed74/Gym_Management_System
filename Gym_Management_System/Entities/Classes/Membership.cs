using Gym_Management_System.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gym_Management_System.Entities.Classes
{
    public class Membership:BaseClass
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing" : EndDate > DateTime.Now ? "Active" : "Expired";
    }
}
