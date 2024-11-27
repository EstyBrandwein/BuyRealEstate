using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    public class Field
    {
        public int ID { get; set; }
        public int FieldCost { get; set; }
        public float MonthlyFinanceCost { get; set; }
        public int MonthsOfFinanceCost { get; set; }
        public float FieldValue { get; set; }
        public float FieldSize { get; set; }
        public int FieldNumber { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int? InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool State { get; set; }
    }

}
