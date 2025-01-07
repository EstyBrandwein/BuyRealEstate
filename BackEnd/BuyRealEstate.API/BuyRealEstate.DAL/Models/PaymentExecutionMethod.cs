using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class PaymentExecutionMethod:BaseClass
    {
        public int ID { get; set; }
        [JsonIgnore] public ICollection<Payment>? Payment { get; set; }
        public string Description { get; set; }

    }
}
