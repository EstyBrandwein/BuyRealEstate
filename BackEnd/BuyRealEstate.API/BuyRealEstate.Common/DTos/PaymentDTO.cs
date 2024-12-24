using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class PaymentDTO
    {
        public int ID { get; set; }
        public string Component { get; set; }
        public double Amount { get; set; }
        public ProfessionalDTO Professional { get; set; }
        public int ProfessionalId { get; set; }
        public DateTime LastPaymentDate { get; set; }
        //  public Document PaymentConfirmation { get; set; }
        public ICollection<DocumentDTO> PaymentConfirmation { get; set; } // Changed to ICollection for better EF Core compatibility

        public ICollection<PaymentExecutionMethodDTO> PaymentExecutionMethod { get; set; }
        public ICollection<PaymentStatusDTO> PaymentStatus { get; set; }
        public ICollection<RelationshipPaymentsPlotsDTO> PaymentPlots { get; set; }
        public ICollection<RelationshipPaymentsProjectsDTO> PaymentProject { get; set; }

    }
}
