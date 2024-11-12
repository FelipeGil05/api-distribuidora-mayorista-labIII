using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BuysController : ControllerBase
    {
        private readonly BuysService _buysService;

        public BuysController(BuysService buysService)
        {
            _buysService = buysService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var buys = _buysService.GetAllBuys();
            return Ok(buys);
        }

        [HttpGet("user/{userId:int}")]
        public IActionResult GetBuysByUserId(int userId)
        {
            var buys = _buysService.GetBuysByUserId(userId);
            return Ok(buys);
        }

        [HttpPost]
        public IActionResult AddBuy([FromBody] BuysDto buysDto)
        {
            var newBuy = _buysService.AddBuy(buysDto);
            return CreatedAtAction(nameof(GetBuysByUserId), new { userId = buysDto.UserBuysId }, newBuy);
        }
    }
}
