using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjectsAsync()
        {
            var projects = await _projectRepository.GetAllProjectsAsync();
            return projects.Select(p => new ProjectDTO
            {
                //Id = p.ID,
                Documents = (ICollection<DTos.DocumentDTO>)p.Documents,
                DeveloperStatus = (ICollection<DTos.DevelopmentStatusDTO>)p.DeveloperStatus,
                GrossProfit = p.GrossProfit,
                Images = p.Images,
                LegalStatus = (ICollection<DTos.LegalStatusDTO>)p.LegalStatus,
                LinkToLead2 = p.LinkToLead2,
                PaymentProject = p.PaymentProject,
                ProjectAddress = p.ProjectAddress,
                //ProjectManager = (DTos.UsersDTO)p.ProjectManager,
                ProjectName = p.ProjectName,
                ProjectType = p.ProjectType
            });
        }

        public async Task<ProjectDTO> GetProjectByIdAsync(int id)
        {
            var p = await _projectRepository.GetProjectByIdAsync(id);
            if (p == null) return null;

            return new ProjectDTO
            {
                Documents = (ICollection<DTos.DocumentDTO>)p.Documents,
                DeveloperStatus = (ICollection<DTos.DevelopmentStatusDTO>)p.DeveloperStatus,
                GrossProfit = p.GrossProfit,
                Images = p.Images,
                LegalStatus = (ICollection<DTos.LegalStatusDTO>)p.LegalStatus,
                LinkToLead2 = p.LinkToLead2,
                PaymentProject = p.PaymentProject,
                ProjectAddress = p.ProjectAddress,
                //ProjectManager = (DTos.UsersDTO)p.ProjectManager,
                ProjectName = p.ProjectName,
                ProjectType = p.ProjectType
            };
        }

        public async Task AddProjectAsync(ProjectDTO p)
        {
            var project = new Project
            {
                Documents = (ICollection<Document>)p.Documents,
                //DeveloperStatus = (ICollection<DevelopmentStatus>)p.DeveloperStatus,
                GrossProfit = p.GrossProfit,
                Images = p.Images,
                //LegalStatus = (ICollection<LegalStatus>)p.LegalStatus,
                LinkToLead2 = p.LinkToLead2,
                PaymentProject = p.PaymentProject,
                ProjectAddress = p.ProjectAddress,
                //ProjectManager =new Users{
                //    Documents = p.ProjectManager.Documents
                //    (Users)p.ProjectManager,
                ProjectName = p.ProjectName,
                ProjectType = p.ProjectType
            };

            await _projectRepository.AddProjectAsync(project);
        }

        public async Task UpdateProjectAsync(ProjectDTO p)
        {
            var project = new Project
            {
                Documents = (ICollection<Document>)p.Documents,
               // DeveloperStatus = (ICollection<DevelopmentStatus>)p.DeveloperStatus,
                GrossProfit = p.GrossProfit,
                Images = p.Images,
              //  LegalStatus =p.LegalStatus,
                LinkToLead2 = p.LinkToLead2,
                PaymentProject = p.PaymentProject,
                ProjectAddress = p.ProjectAddress,
                //ProjectManager =new Users{
                //    Documents = p.ProjectManager.Documents
                //    (Users)p.ProjectManager,
                ProjectName = p.ProjectName,
                ProjectType = p.ProjectType
            };

            await _projectRepository.UpdateProjectAsync(project);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteProjectAsync(id);
        }
    }
}
