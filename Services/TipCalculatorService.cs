using TipCalculatorAPI.Models;

namespace TipCalculatorAPI.Services
{
    public class TipCalculatorService : ITipCalculatorService
    {
        public TipResponse Calculate(TipRequest request)
        {
            var tipAmount = request.BillAmount * request.TipPercentage / 100;
            var totalAmount = request.BillAmount + tipAmount;
            var tipPerPerson = tipAmount / request.NumberOfPeople;
            var totalPerPerson = totalAmount / request.NumberOfPeople;

            return new TipResponse
            {
                TipPerPerson = tipPerPerson,
                TotalPerPerson = totalPerPerson
            };
        }
    }
}
