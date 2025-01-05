using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class RelationshipCustomersPlots:BaseClass
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int PlotID { get; set; }
        public Plot Plot { get; set; }

    }
}
