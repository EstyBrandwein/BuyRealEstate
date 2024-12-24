using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Common.DTos
{
    public class ProfessionalDTO:UsersDTO
    {
        public string WebsiteAddress { get; set; }
        public string Professtion { get; set; }
        public ICollection<PaymentDTO> Payments { get; set; }
    }
}
