using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infrastructure.Repository
{
    public class MembershipRepository : IMembershipRepository
    {
        private readonly ProductDbContext _context;

        public MembershipRepository(ProductDbContext context)
        {
            _context = context;
        }

        public Membership ActivateMembership(int userId, DateTime startDate)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return null;
            }

            var membership = new Membership
            {
                UserId = userId,
                StartDate = startDate,
                EndDate = startDate,
                IsActive = true
            };

            _context.Memberships.Add(membership);
            _context.SaveChanges();
            return membership;
        }

        public Membership DesactivateMembership(int userId, DateTime EndDate)
        {
            var membership = _context.Memberships
                .FirstOrDefault(m => m.UserId == userId && m.IsActive);

            if (membership == null)
            {
                return null;
            }

            membership.IsActive = false;
            membership.EndDate = EndDate;

            _context.Memberships.Remove(membership);
            _context.SaveChanges();
            return membership;
        }
    }
}
