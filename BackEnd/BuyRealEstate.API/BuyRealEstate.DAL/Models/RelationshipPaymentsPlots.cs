﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class RelationshipPaymentsPlots
    {
        public int ID { get; set; }
        public int PlotID { get; set; }
        public int PaymentID { get; set; }
        public PaymentStatus paymentStutus { get; set; }
    }
}
