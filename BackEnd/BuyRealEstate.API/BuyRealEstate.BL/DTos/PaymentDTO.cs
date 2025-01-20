using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class PaymentDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string movement { get; set; }
        public string dose { get; set; }
        public string HNagainst { get; set; }
        public DateTime Datereference { get; set; }
        public DateTime DataValue { get; set; }
        public string Detiels { get; set; }
        public int Surplus { get; set; }
        public double Amount { get; set; }
        public Professional Professional { get; set; }
        public int ProfessionalId { get; set; }
        public DateTime LastPaymentDate { get; set; }
        //  public Document PaymentConfirmation { get; set; }
        public ICollection<DocumentDTO>? PaymentConfirmation { get; set; } // Changed to ICollection for better EF Core compatibility
        public int PaymentExecutionMethodID { get; set; }

        public PaymentExecutionMethod? PaymentExecutionMethod { get; set; }
        public PaymentStatus? PaymentStatus { get; set; }
        public int PaymentStatusId { get; set; }

        public ICollection<RelationshipPaymentsPlots>? PaymentPlots { get; set; }
        public ICollection<RelationshipPaymentsProjects>? PaymentProject { get; set; }
    }
}
