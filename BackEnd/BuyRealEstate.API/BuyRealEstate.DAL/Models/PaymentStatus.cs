using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{

    public class PaymentStatus:BaseClass
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public ICollection<Payment> Payment { get; set; }
        //public int? PaymentId { get; set; }
    }
}
