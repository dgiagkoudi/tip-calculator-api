using TipCalculatorAPI.Models;

namespace TipCalculatorAPI.Services
{
    public interface ITipCalculatorService
    {
        TipResponse Calculate(TipRequest request);
    }
}
