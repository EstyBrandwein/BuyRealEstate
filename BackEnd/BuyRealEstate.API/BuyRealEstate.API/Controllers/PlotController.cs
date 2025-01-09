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
    public class PlotController : ControllerBase
    {
        private readonly IPlotService _plotService;

        public PlotController(IPlotService plotService)
        {
            _plotService = plotService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlots()
        {
            var plots = await _plotService.GetAllPlotsAsync();
            return Ok(plots);
        }
        [HttpGet("userplot")]
        public async Task<IActionResult> GetAllPlotsByUserID([FromBody] int id)
        {
            var plots = await _plotService.GetAllPlotByUserIdAsync(id);
            return Ok(plots);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlot(int id)
        {
            var plot = await _plotService.GetPlotByIdAsync(id);
            if (plot == null) return NotFound();
            return Ok(plot);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlot([FromBody] PlotDTO plot)
        {
            await _plotService.AddPlotAsync(plot);
            return CreatedAtAction(nameof(GetPlot), new { id = plot.ID }, plot);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlot(int id, [FromBody] PlotDTO plot)
        {
            if (id != plot.ID) return BadRequest();
            await _plotService.UpdatePlotAsync(plot);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlot(int id)
        {
            await _plotService.DeletePlotAsync(id);
            return NoContent();
        }
    }
}
