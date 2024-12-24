
using BuyRealEstate.Common.DTos;

namespace BuyRealEstate.Common.DTOs
{
    public class ProjectDTO
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public UsersDTO ProjectManager { get; set; }   // Assuming Users is a related class
        public double GrossProfit { get; set; }
        public string LinkToYad2 { get; set; }
        public bool ProjectType { get; set; } 
        public ICollection<DocumentDTO> Documents { get; set; } 
        public ICollection<ImageDTO> Images { get; set; }
        public ICollection<DevelopmentStatusDTO> DeveloperStatus { get; set; }
        public ICollection<LegalStatusDTO> LegalStatus { get; set; }
        public ICollection<RelationshipPaymentsProjectsDTO> PaymentProject { get; set; }
    }
}
