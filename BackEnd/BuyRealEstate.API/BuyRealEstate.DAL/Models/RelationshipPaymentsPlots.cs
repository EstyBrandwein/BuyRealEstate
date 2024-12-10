using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class RelationshipPaymentsPlots:BaseClass
    {
        public int ID { get; set; }
        public int PlotID { get; set; }
        public Plot plot { get; set; }
        public int PaymentID { get; set; }
        public Payment payment { get; set; }
        public PaymentStatus paymentStutus { get; set; }

    }
}
