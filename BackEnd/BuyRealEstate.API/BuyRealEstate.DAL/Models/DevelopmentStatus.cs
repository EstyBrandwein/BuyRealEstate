using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{

    public class DevelopmentStatus:BaseClass
    {
        public int Id { get; set; }
        public string Status { get; set; }
        [JsonIgnore] public ICollection<Project>? Project { get; set; }
        public int ProjectID { get; set; }

    }
}
