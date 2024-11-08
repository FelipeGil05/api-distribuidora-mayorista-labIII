using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_userService.GetUsers());
        }

        [HttpPost]
        public IActionResult Post(UserDto userDto)
        {
            return Ok(_userService.AddUser(userDto));
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] UserDto userDto)
        {
            var updatedUser = _userService.UpdateUser(id, userDto);

            if (updatedUser == null)
            {
                return NotFound($"Usuario con ID {id} no encontrado.");
            }

            return Ok(updatedUser);
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

    }
}
