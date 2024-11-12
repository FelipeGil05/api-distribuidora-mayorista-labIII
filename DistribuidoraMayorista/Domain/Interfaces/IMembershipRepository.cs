using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMembershipRepository
    {
        int GetUserId(int number);
        Membership ActivateMembership(int userId, DateTime StartDate);
        Membership DesactivateMembership(int userId, DateTime EndDate);
    }
}
