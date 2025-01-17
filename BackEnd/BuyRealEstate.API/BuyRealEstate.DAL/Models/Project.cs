﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BuyRealEstate.Domain.Models
{
    public class Project : BaseClass
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public User ProjectManager { get; set; }   // Assuming Users is a related class
        public double GrossProfit { get; set; }
        public string LinkToLead2 { get; set; }
        public bool ProjectType { get; set; } // Clarify if this represents a specific type or a flag
        [JsonIgnore] public ICollection<Document>  Documents { get; set; } // Changed to ICollection for better EF Core compatibility
        [JsonIgnore] public ICollection<Image> Images { get; set; }
        [JsonIgnore] public ICollection<Plot>? Plots { get; set; }
        public DevelopmentStatus DeveloperStatus { get; set; }
        public LegalStatus LegalStatus { get; set; }
        public int LegalStatusId { get; set; }
        // Changed to ICollection for better EF Core compatibility
        [JsonIgnore] public ICollection<RelationshipPaymentsProjects>? PaymentProject { get; set; }
        public int DeveloperStatusID { get; set; }
        public int ProjectManagerID { get;  set; }

    }
}
