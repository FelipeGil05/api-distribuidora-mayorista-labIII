using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMembershipRepository
    {
        Membership ActivateMembership(int userId, DateTime StartDate);
        Membership DesactivateMembership(int userId, DateTime EndDate);
    }
}
