using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class RelationshipPaymentsProjects:BaseClass
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public Payment payment { get; set; }
        public int ProjectID { get; set; }
        public Project project { get; set; }
        public PaymentStatus paymentStutus { get; set; }
        public int paymentStutusID { get; set; }



    }
}
