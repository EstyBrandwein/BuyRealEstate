using Microsoft.AspNetCore.Mvc;
using BuyRealEstate.Core.Services;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTos;
namespace BuyRealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _imageService;
        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            var image = await _imageService.GetImageByIdAsync(id);
            if (image == null) return NotFound();
            return File(image.ImageData, image.FileType);
        }
        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetImagesByProject(int projectId)
        {
            var images = await _imageService.GetImagesByProjectIdAsync(projectId);
            return Ok(images);
        }
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] string description, [FromForm] int projectId, [FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0) return BadRequest("Invalid file.");
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            var image = new ImageDTO
            {
                ImageDescription = description,
                ProjectID = projectId,
                ImageData = memoryStream.ToArray(),
                FileType = file.ContentType
            };
            await _imageService.AddImageAsync(image);
            return Ok(image);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            await _imageService.DeleteImageAsync(id);
            return NoContent();
        }
    }
}