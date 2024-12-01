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
        public LegalStatus LegalStatus { get; set; }
        public string ProjectManager { get; set; }
        public DevelopmentStatus DevelopmentStatus { get; set; }
        public double GrossProfit { get; set; }
        public string LinkToLead2 { get; set; }
        public bool ProjectType { get; set; }
    }

}
