using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class PaymentExecutionMethod:BaseClass
    {
        public int ID { get; set; }
        public int PaymentExecutionMethodID { get; set; }
        public Payment Payment { get; set; }

    }
}
