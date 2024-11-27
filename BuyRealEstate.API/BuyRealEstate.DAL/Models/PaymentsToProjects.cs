using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class PaymentProject
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public int PaymentStatusID { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int? InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool State { get; set; }
    }

}
