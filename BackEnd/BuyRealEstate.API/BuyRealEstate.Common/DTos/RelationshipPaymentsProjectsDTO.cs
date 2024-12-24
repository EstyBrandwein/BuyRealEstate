using BuyRealEstate.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class RelationshipPaymentsProjectsDTO
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public PaymentDTO payment { get; set; }
        public int ProjectID { get; set; }
        public ProjectDTO project { get; set; }
        public PaymentStatusDTO paymentStutus { get; set; }
    }
}
