using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class BaseClass
    {
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int InsertUser { get; set; }
        public int UpdateUser { get; set; }
        public bool State { get; set; }
    }
}
