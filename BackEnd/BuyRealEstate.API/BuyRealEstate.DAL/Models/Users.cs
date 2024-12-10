using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class Users:BaseClass
    {
        public int ID { get; set; }
        public Permission Permission { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<RelationshipCustomersPlots> CustomerPlots { get; set; }
        public ICollection<Document> Documents { get; set; }

        
    }

}
