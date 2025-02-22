using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrEmpBudgetController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpBudgetController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpBudget
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrEmpBudget>>> GetHrEmpBudgets()
        {
            return await _context.HrEmpBudgets.ToListAsync();
        }

        // GET: api/HrEmpBudget/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpBudget>> GetHrEmpBudget(decimal id)
        {
            var hrempbudget = await _context.HrEmpBudgets.FindAsync(id);

            if (hrempbudget == null)
            {
                return NotFound();
            }

            return hrempbudget;
        }

        // PUT: api/HrEmpBudget/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpBudget(decimal id, HrEmpBudget hrempbudget)
        {
            if (id != hrempbudget.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempbudget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpBudgetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HrEmpBudget
        [HttpPost]
        public async Task<ActionResult<HrEmpBudget>> PostHrEmpBudget(HrEmpBudget hrempbudget)
        {
            _context.HrEmpBudgets.Add(hrempbudget);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpBudget", new { id = hrempbudget.FCompanyId }, hrempbudget);
        }

        // DELETE: api/HrEmpBudget/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpBudget(decimal id)
        {
            var hrempbudget = await _context.HrEmpBudgets.FindAsync(id);
            if (hrempbudget == null)
            {
                return NotFound();
            }

            _context.HrEmpBudgets.Remove(hrempbudget);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpBudgetExists(decimal id)
        {
            return _context.HrEmpBudgets.Any(e => e.FCompanyId == id);
        }
    }
}
