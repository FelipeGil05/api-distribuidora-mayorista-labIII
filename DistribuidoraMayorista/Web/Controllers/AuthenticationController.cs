using Application.Interfaces;
using Application.Models.Responses;
using Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ICustomAuthenticationService _customAuthenticationService;

        public AuthenticationController(IConfiguration config, ICustomAuthenticationService autenticacionService)
        {
            _config = config; //Hacemos la inyección para poder usar el appsettings.json
            _customAuthenticationService = autenticacionService;
        }
        [HttpPost("login")] //Vamos a usar un POST ya que debemos enviar los datos para hacer el login
        public ActionResult<LoginResponses> Login(LoginRequest loginRequest) //Enviamos como parámetro la clase que creamos arriba
        {
            var loginResponses = _customAuthenticationService.Login(loginRequest);

            if (loginResponses == null)
            {
                return Unauthorized("Credenciales incorrectas.");
            }

            return Ok(loginResponses);
        }

    }
}
