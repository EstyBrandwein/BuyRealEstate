using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class Document
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public byte[] DocumentData { get; set; }
        public string DocumentDescription { get; set; }
    }
}
