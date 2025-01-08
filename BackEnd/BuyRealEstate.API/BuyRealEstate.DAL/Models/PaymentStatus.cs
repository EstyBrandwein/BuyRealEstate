using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{

    public class PaymentStatus:BaseClass
    {
        public int Id { get; set; }
        public string Status { get; set; }
        [JsonIgnore] public ICollection<Payment> Payments { get; set; }
    }
}
