﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyRealEstate.Domain.Models
{
    public class Professional : User
    {
        public string WebsiteAddress { get; set; }
        public string Professtion { get; set; }
        [JsonIgnore] public ICollection<Payment>? Payments { get; set; } // Correctly define Payments as a collection
    }
}
