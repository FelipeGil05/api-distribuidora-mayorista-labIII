using Application.Models;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class DateMembershipService
    {
        private readonly IDateMembershipRepository _repository;

        public DateMembershipService(IDateMembershipRepository repository)
        {
            _repository = repository;
        }

        public bool UpdateMembership(DateMembershipDto dto)
        {
            var membership = _repository.GetDateMembership();

            if (membership == null)
            {
                return false;
            }

            membership.MembershipPrice = dto.MembershipPrice;
            membership.MembershipTitle = dto.MembershipTitle;
            membership.MembershipDescription = dto.MembershipDescription;

            _repository.UpdateDateMembership(membership);
            return true;
        }

        public DateMembershipDto GetMembershipDetails()
        {
            var membership = _repository.GetDateMembership();
            if (membership == null)
                return null;

            return new DateMembershipDto
            {
                MembershipPrice = membership.MembershipPrice,
                MembershipTitle = membership.MembershipTitle,
                MembershipDescription = membership.MembershipDescription
            };
        }

    }
}
