using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class RelationshipPaymentsProjects
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public int ProjectID { get; set; }

        public PaymentStatus paymentStutus { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public string State { get; set; }

    }
}
