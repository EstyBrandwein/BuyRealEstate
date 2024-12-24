using BuyRealEstate.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class RelationshipPaymentsPlotsDTO
    {
        public int ID { get; set; }
        public int PlotID { get; set; }
        public PlotDTO plot { get; set; }
        public int PaymentID { get; set; }
        public PaymentDTO payment { get; set; }
        public PaymentStatusDTO paymentStutus { get; set; }
    }
}
