using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuyRealEstate.Domain.Models
{

    public class Payment:BaseClass
    {
        public int ID { get; set; }
        public string Component { get; set; }
        public double Amount { get; set; }
        public Professional? Professional { get; set; }
        public int? ProfessionalId   { get; set; }
        public DateTime? LastPaymentDate { get; set; }
      //  public Document PaymentConfirmation { get; set; }
        public ICollection<Document>? PaymentConfirmation { get; set; } // Changed to ICollection for better EF Core compatibility

        public PaymentExecutionMethod? PaymentExecutionMethod { get; set; }
        public int? PaymentExecutionMethodId { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public int PaymentStatusId { get; set; }
        public ICollection<RelationshipPaymentsPlots>? PaymentPlots { get; set; }
        public ICollection<RelationshipPaymentsProjects>? PaymentProject { get; set; }
    }
}
