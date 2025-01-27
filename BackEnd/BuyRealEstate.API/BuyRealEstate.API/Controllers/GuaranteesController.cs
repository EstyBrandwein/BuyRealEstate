using Microsoft.AspNetCore.Mvc;
using BuyRealEstate.Core;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core.DTos;
//using BuyRealEstate.BL.Interfaces;
//using BuyRealEstate.BLL.DTOs;
namespace BuyRealEstate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuaranteesController : ControllerBase
    {
        private readonly IGuaranteesService _guaranteesService;
        public GuaranteesController(IGuaranteesService guaranteesService)
        {
            _guaranteesService = guaranteesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGuaranteess()
        {
            var guaranteess = await _guaranteesService.GetAllGuaranteessAsync();
            return Ok(guaranteess);
        }
        [HttpGet("guarantees")]
        public async Task<IActionResult> GetAllGuaranteess([FromBody] int userId)
        {
            var guaranteess = await _guaranteesService.GetAllGuaranteesByUserIdAsync(userId);
            return Ok(guaranteess);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuarantees(int id)
        {
            var guarantees = await _guaranteesService.GetGuaranteesByIdAsync(id);
            if (guarantees == null) return NotFound();
            return Ok(guarantees);
        }
        [HttpPost]
        public async Task<IActionResult> AddGuarantees([FromBody] GuaranteesDTO guarantees)
        {
            await _guaranteesService.AddGuaranteesAsync(guarantees);
            return CreatedAtAction(nameof(GetGuarantees), new { id = guarantees.Id }, guarantees);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGuarantees(int id, [FromBody] GuaranteesDTO guarantees)
        {
            if (id != guarantees.Id) return BadRequest();
            await _guaranteesService.UpdateGuaranteesAsync(guarantees);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuarantees(int id)
        {
            await _guaranteesService.DeleteGuaranteesAsync(id);
            return NoContent();
        }
    }
}