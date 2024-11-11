using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;

namespace Application.Services
{
    public class MembershipService
    {
        private readonly IMembershipRepository _membershipRepository;

        public MembershipService(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        public Result ActivateMembership(int userId, DateTime startDate)
        {
            var membership = _membershipRepository.ActivateMembership(userId, startDate);
            if (membership == null)
            {
                return new Result
                {
                    IsSuccess = false,
                    Message = "Hubo un error al activar la membresía."
                };
            }

            return new Result
            {
                IsSuccess = true,
                Message = "Membresía activada correctamente."
            };
        }

        public Result DesactivateMembership(int userId, DateTime endDate)
        {
            var membership = _membershipRepository.DesactivateMembership(userId, endDate);
            if (membership == null)
            {
                return new Result
                {
                    IsSuccess = false,
                    Message = "Hubo un error al desactivar la membresía."
                };
            }

            return new Result
            {
                IsSuccess = true,
                Message = "Membresía desactivada correctamente."
            };
        }
    }
}
