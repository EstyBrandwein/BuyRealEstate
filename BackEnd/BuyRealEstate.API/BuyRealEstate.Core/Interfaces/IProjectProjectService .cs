using BuyRealEstate.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDTO>> GetAllProjectsAsync();
        Task<ProjectDTO> GetProjectByIdAsync(int id);
        Task AddProjectAsync(ProjectDTO plot);
        Task UpdateProjectAsync(ProjectDTO plot);
        Task DeleteProjectAsync(int id);
    }
}
