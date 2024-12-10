using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class RelationshipPaymentsProjects
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public int ProjectID { get; set; }

        public PaymentStatus paymentStutus { get; set; }

    }
}
