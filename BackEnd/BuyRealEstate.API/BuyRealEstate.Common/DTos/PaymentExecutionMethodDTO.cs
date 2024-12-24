using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class PaymentExecutionMethodDTO
    {
        public int ID { get; set; }
        public int PaymentExecutionMethodID { get; set; }
        public PaymentDTO Payment { get; set; }
    }
}
