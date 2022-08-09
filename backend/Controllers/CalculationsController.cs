using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Controllers
{
    [Route("Calculations")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        private readonly CalculationContext _context;
        List<Calculation> lastNCalculations;

        public CalculationsController(CalculationContext context)
        {
            _context = context;
            lastNCalculations = new List<Calculation>();
        }

        // GET: api/Calculations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calculation>>> GetCalculations()
        {
          if (_context.Calculations == null)
          {
              return NotFound();
          }
            return await _context.Calculations.ToListAsync();
        }

        // GET: api/Calculations/5
        [HttpGet("{n}")]
        public async Task<ActionResult<IEnumerable<Calculation>>> GetCalculation(int n)
        {
          if (_context.Calculations == null)
          {
              return NotFound();
          }

            //list of Calculations

            lastNCalculations = await _context.Calculations.ToListAsync();
            //reverse lastNCalculations
            lastNCalculations.Reverse();

            return lastNCalculations.Take(n).Reverse().ToList();
        }



        // POST: api/Calculations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Calculation>> PostCalculation(Calculation calculation)
        {
          if (_context.Calculations == null)
          {
              return Problem("Entity set 'CalculationContext.Calculations'  is null.");
          }
            _context.Calculations.Add(calculation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCalculation), new { id = calculation.Id }, calculation);
        }

        

        private bool CalculationExists(long id)
        {
            return (_context.Calculations?.Any(e => e.Id == id)).GetValueOrDefault();
        }



        //calculations
        [HttpGet("{operationName}/{number}")]
        public async Task<IActionResult> GetResult(string operationName, long number)
        {
            Operation operation = null;
            switch (operationName)
            {
                case "fibbo":
                    operation = new Fibonacci();
                    break;
                case "fact":
                    operation = new Factorial();
                    break;
                case "sqrt":
                    operation = new SquareRoot();
                    break;
                case "sq":
                    operation = new Square();
                    break;
                default:
                    return NotFound();

            }
            await PostCalculation(new Calculation() { Name = operationName, Number = number});
            return Ok(operation.calculate(number));
        } 
    }
}
