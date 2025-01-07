namespace BuyRealEstate.Core.DTOs
{
    public class PlotDTO
    {
        public int ID { get; set; }
        public int PlotCost { get; set; }
        public double MonthlyFundingCost { get; set; }
        public int MonthsForFundingCost { get; set; }
        public double PlotValue { get; set; }
        public double PlotSize { get; set; }
        public int PlotNumber { get; set; }
        public ProjectDTO? Project { get; set; }
    }
}
