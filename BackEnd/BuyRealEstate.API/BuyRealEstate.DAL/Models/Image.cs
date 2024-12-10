using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class Image
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string ImageDescription { get; set; }
        public byte[] ImageData { get; set; }
    }
}
