using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuyRealEstate.DAL.Models
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
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public string State { get; set; }
    }
}
