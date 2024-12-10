using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuyRealEstate.Domain.Models
{

    public class Payment
    {
        public int ID { get; set; }
        public string Component { get; set; }
        public double Amount { get; set; }
        public Professional Person { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public byte[] PaymentConfirmation { get; set; }
        public PaymentExecutionMethod PaymentExecutionMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
