using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class DateMembershipRepository : IDateMembershipRepository
    {
        private readonly ProductDbContext _context;

        public DateMembershipRepository(ProductDbContext context)
        {
            _context = context;
        }

        public DateMembership GetDateMembership()
        {
            return _context.DateMembership.FirstOrDefault();
        }

        public void UpdateDateMembership(DateMembership membership)
        {
            _context.DateMembership.Update(membership);
            _context.SaveChanges();
        }
    }
}
