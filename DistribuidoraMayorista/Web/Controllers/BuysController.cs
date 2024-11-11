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

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var buy = _buysService.GetBuyById(id);
            if (buy == null)
            {
                return NotFound($"Compra con ID {id} no encontrada.");
            }
            return Ok(buy);
        }

        [HttpGet("user/{userId:int}")]
        public IActionResult GetBuysByUserId(int userId)
        {
            var buys = _buysService.GetBuysByUserId(userId);
            return Ok(buys);
        }

        [HttpPost]
        public IActionResult Post(BuysDto buysDto)
        {
            _buysService.AddBuy(buysDto);
            return CreatedAtAction(nameof(GetById), new { id = buysDto.BuysId }, buysDto);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] BuysDto buysDto)
        {
            if (id != buysDto.BuysId)
            {
                return BadRequest("El ID de la compra no coincide.");
            }

            var updatedBuy = _buysService.UpdateBuy(id, buysDto);
            if (updatedBuy == null)
            {
                return NotFound($"Compra con ID {id} no encontrada.");
            }

            return Ok(updatedBuy);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _buysService.DeleteBuy(id);
            return Ok();
        }
    }
}
