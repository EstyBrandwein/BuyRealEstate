using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class Plot
    {
        public int ID { get; set; }
        public int PlotCost { get; set; }
        public double MonthlyFundingCost { get; set; }
        public int MonthsForFundingCost { get; set; }
        public double PlotValue { get; set; }
        public double PlotSize { get; set; }
        public int PlotNumber { get; set; }
        public Project Project { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public string State { get; set; }
    }
}
