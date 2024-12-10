using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class LegalStatus:BaseClass
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Project Project { get; set; }
        public int ProjectID { get; set; }

    }

}
