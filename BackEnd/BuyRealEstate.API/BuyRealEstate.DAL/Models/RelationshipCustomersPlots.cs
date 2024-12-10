using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class RelationshipCustomersPlots
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int PlotID { get; set; }
    }
}
