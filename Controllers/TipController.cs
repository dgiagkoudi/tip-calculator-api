using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TipCalculatorAPI.Models;
using TipCalculatorAPI.Services;

namespace TipCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipController : ControllerBase
    {
        private readonly ITipCalculatorService _service;

        public TipController(ITipCalculatorService service)
        {
            _service = service;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] TipRequest request)
        {
            if (request.BillAmount <= 0)
                return BadRequest("Bill amount must be greater than zero.");

            if (request.TipPercentage < 0)
                return BadRequest("Tip percentage cannot be negative.");

            if (request.NumberOfPeople <= 0)
                return BadRequest("Number of people must be greater than zero.");

            var result = _service.Calculate(request);
            return Ok(result);
        }
    }
}
