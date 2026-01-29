namespace TipCalculatorAPI.Models
{
    public class TipRequest
    {
        public decimal BillAmount { get; set; }
        public int TipPercentage { get; set; }
        public int NumberOfPeople { get; set; } = 1;
    }
}
