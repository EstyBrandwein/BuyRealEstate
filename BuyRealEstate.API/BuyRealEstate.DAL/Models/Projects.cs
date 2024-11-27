using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public int? LegalStatusID { get; set; }
        public LegalStatus LegalStatus { get; set; }
        public string TrusteeName { get; set; }
        public int? DevelopmentStatusID { get; set; }
        public DevelopmentStatus DevelopmentStatus { get; set; }
        public float? GrossProfit { get; set; }
        public string LinkToYad2 { get; set; }
        public bool ProjectType { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int? InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool State { get; set; }
    }

}
