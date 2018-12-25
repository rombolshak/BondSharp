namespace BondSharp
{
    public class BondState
    {
        public Bond Bond { get; }
        public decimal PercentPrice { get; set; }
        public decimal AccruedInterest { get; set; }
    }
}