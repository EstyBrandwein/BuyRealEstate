using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class ImageDTO
    {
        public int ID { get; set; }
        public string ImageDescription { get; set; }
        public byte[] ImageData { get; set; }
        public int ProjectID { get; set; } // Foreign Key to Project
        public ProjectDTO Project { get; set; } // Navigation property to relate to Project
        public string FileType { get; set; }
    }
}
