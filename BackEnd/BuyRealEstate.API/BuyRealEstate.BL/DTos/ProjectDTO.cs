
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;

namespace BuyRealEstate.Core.DTOs
{
    public class ProjectDTO
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public UsersDTO? ProjectManager { get; set; }   // Assuming Users is a related class
        public double GrossProfit { get; set; }
        public string LinkToLead2 { get; set; }
        public bool ProjectType { get; set; } // Clarify if this represents a specific type or a flag
        public ICollection<DocumentDTO>? Documents { get; set; } // Changed to ICollection for better EF Core compatibility
        public ICollection<ImageDTO>? Images { get; set; }
        //public ICollection<PlotDTO> Plots { get; set; }
        public DevelopmentStatusDTO? DeveloperStatus { get; set; }
        public LegalStatusDTO? LegalStatus { get; set; }
        public int LegalStatusId { get; set; }
        public ICollection<RelationshipPaymentsProjects>? PaymentProject { get; set; }
        public int DeveloperStatusID { get; set; }
        public int ProjectManagerID { get; set; }

    }
}
