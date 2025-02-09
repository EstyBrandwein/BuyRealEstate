using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class VerificationResult
    {
        public bool IsSuccessful { get; set; }
        public int? UserId { get; set; } // יוחזר רק אם האימות הצליח
        public string ErrorMessage { get; set; } // למקרה של שגיאות
    }

}
