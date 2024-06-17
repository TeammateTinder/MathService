using MathService.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : Controller
    {
        CalculatorService _calculator;
        public MathController(CalculatorService calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("Add")]
        public IActionResult Add(int a, int b)
        {
            int result = _calculator.Add(a, b);
            return Ok(result); // This will return a 200 OK response with the result as the content
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(int a, int b)
        {
            int result = _calculator.Multiply(a, b);
            return Ok(result); // This will return a 200 OK response with the result as the content
        }
    }
}
