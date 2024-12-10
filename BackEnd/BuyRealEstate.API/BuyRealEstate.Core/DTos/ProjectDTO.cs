
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;

namespace BuyRealEstate.Core.DTOs
{
    public class ProjectDTO
    {
        //public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public UsersDTO ProjectManager { get; set; }   // Assuming Users is a related class
        public double GrossProfit { get; set; }
        public string LinkToLead2 { get; set; }
        public bool ProjectType { get; set; } 
        public ICollection<DocumentDTO> Documents { get; set; } 
        public ICollection<Image> Images { get; set; }
        //public ICollection<Plot> Plots { get; set; }
        public ICollection<DevelopmentStatusDTO> DeveloperStatus { get; set; }
        public ICollection<LegalStatusDTO> LegalStatus { get; set; }
        public ICollection<RelationshipPaymentsProjects> PaymentProject { get; set; }
    }
}
