using BuyRealEstate.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class RelationshipCustomersPlotsDTO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public UsersDTO User { get; set; }
        public int PlotID { get; set; }
        public PlotDTO Plot { get; set; }
    }
}
