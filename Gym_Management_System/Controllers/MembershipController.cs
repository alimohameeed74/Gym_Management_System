using Gym_Management_System.Repositories.Interfaces;

namespace Gym_Management_System.Controllers
{
    public class MembershipController
    {
        private readonly IMembershipRepository _membershipRepository;

        public MembershipController(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }


    }
}
