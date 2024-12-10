using Microsoft.AspNetCore.Mvc;
using BuyRealEstate.Core;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTOs;
//using BuyRealEstate.BLL.Interfaces;
//using BuyRealEstate.BLL.DTOs;

namespace BuyRealEstate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProject()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null) return NotFound();
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> AddProject(ProjectDTO project)
        {
            await _projectService.AddProjectAsync(project);
            return CreatedAtAction(nameof(GetProject), project);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, ProjectDTO project)
        {
           // if (id != project.ID) return BadRequest();
            await _projectService.UpdateProjectAsync(project);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            await _projectService.DeleteProjectAsync(id);
            return NoContent();
        }
    }
}
