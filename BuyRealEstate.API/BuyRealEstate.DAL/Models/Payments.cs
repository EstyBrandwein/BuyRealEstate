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
        public float Amount { get; set; }
        public int ContactID { get; set; }
        public Professional Contact { get; set; }
        public DateTime DueDate { get; set; }
        public byte[] ApprovalFile { get; set; }
        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int PaymentStatusID { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int? InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool State { get; set; }
    }

}
