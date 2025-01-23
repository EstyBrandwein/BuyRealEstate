using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuyRealEstate.Domain.Models
{
    public class Guarantees:BaseClass
    {
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int VoucherNumber { get; set; }
        public int Amount { get; set; }
        public bool IsPaid { get; set; }
        public bool GuaranteeUssued { get; set; }
        public string? Note { get; set; }

    }
}
