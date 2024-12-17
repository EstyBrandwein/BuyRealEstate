namespace BuyRealEstate.Domain.Models
{
    public class RelationshipPaymentsPlots:BaseClass
    {
        public int ID { get; set; }
        public int PlotID { get; set; }
        public Plot? plot { get; set; }
        public int PaymentID { get; set; }
        public Payment? payment { get; set; }
        public int paymentStutusId { get; set; }
        public PaymentStatus? paymentStutus { get; set; }

    }
}
