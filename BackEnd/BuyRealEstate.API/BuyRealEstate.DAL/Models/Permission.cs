using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class Permission:BaseClass
    {
        public int Id { get; set; }
        public string permission { get; set; }
        public ICollection<Users>? users { get; set; }
        public ICollection<Professional>? Professional { get; set; }
    }
}