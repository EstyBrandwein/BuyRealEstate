using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class PaymentStatusDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public PaymentDTO Payment { get; set; }
        public int PaymentId { get; set; }
    }
}
