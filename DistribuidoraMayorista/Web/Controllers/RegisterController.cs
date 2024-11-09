using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly UserService _userService;
        public RegisterController(UserService userService)
        {
            _userService = userService;
        }
    
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post(UserDto userDto)
        {
            return Ok(_userService.AddUser(userDto));
        }
    }
}
