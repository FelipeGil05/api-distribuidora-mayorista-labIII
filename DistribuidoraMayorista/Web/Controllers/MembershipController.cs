using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MembershipController : ControllerBase
    {
        private readonly MembershipService _membershipService;

        public MembershipController(MembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpPost("activate")]
        public IActionResult ActivateMembership([FromBody] ActivateMembershipRequest request)
        {
            var result = _membershipService.ActivateMembership(request.UserId, request.StartDate);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(new { message = result.Message });
        }

        [HttpDelete("desactivate")]
        public IActionResult DesactivateMembership([FromBody] DesactivateMembershipRequest request)
        {
            var result = _membershipService.DesactivateMembership(request.UserId, request.EndDate);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(new { message = result.Message });
        }
    }
}
