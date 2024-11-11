using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DateMembershipController : ControllerBase
    {
        private readonly DateMembershipService _service;

        public DateMembershipController(DateMembershipService service)
        {
            _service = service;
        }

        [HttpPut("update")]
        public IActionResult UpdateDateMembership([FromBody] DateMembershipDto dto)
        {
            var success = _service.UpdateMembership(dto);

            if (!success)
            {
                return NotFound("No se encontró la configuración de la membresía.");
            }

            return Ok("Membresía actualizada correctamente.");
        }

        [HttpGet("details")]
        public IActionResult GetMembershipDetails()
        {
            var membership = _service.GetMembershipDetails();
            if (membership == null)
            {
                return NotFound("No se encontró la configuración de la membresía.");
            }

            return Ok(membership);
        }
    }
}
