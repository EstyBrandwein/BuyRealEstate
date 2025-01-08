using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class Plot:BaseClass
    {
        public int ID { get; set; }
        public int PlotCost { get; set; }
        public double MonthlyFundingCost { get; set; }
        public int MonthsForFundingCost { get; set; }
        public double PlotValue { get; set; }
        public double PlotSize { get; set; }
        public int PlotNumber { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
        //public ICollection<RelationshipCustomersPlots> CustomerPlots { get; set; }
        public ICollection<RelationshipPaymentsPlots> PaymentPlots { get; set; }

    }
}
