using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
using Microsoft.AspNetCore.Authorization;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class HrEmpBudgetSerController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpBudgetSerController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpBudgetSer
        [HttpGet]
        public async Task<ActionResult<PaginationList<HrEmpBudgetSer>>> GetHrEmpBudgetSers([FromQuery]PaginationParams paginationParams)
        {
            return await _context.HrEmpBudgetSers.GetPagedAsync(paginationParams);
        }

        // GET: api/HrEmpBudgetSer/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpBudgetSer>> GetHrEmpBudgetSer(decimal id)
        {
            var hrempbudgetser = await _context.HrEmpBudgetSers.FindAsync(id);

            if (hrempbudgetser == null)
            {
                return NotFound();
            }

            return hrempbudgetser;
        }

        // PUT: api/HrEmpBudgetSer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpBudgetSer(decimal id, HrEmpBudgetSer hrempbudgetser)
        {
            if (id != hrempbudgetser.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempbudgetser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpBudgetSerExists(id))
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

        // POST: api/HrEmpBudgetSer
        [HttpPost]
        public async Task<ActionResult<HrEmpBudgetSer>> PostHrEmpBudgetSer(HrEmpBudgetSer hrempbudgetser)
        {
            _context.HrEmpBudgetSers.Add(hrempbudgetser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpBudgetSer", new { id = hrempbudgetser.FCompanyId }, hrempbudgetser);
        }

        // DELETE: api/HrEmpBudgetSer/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpBudgetSer(decimal id)
        {
            var hrempbudgetser = await _context.HrEmpBudgetSers.FindAsync(id);
            if (hrempbudgetser == null)
            {
                return NotFound();
            }

            _context.HrEmpBudgetSers.Remove(hrempbudgetser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpBudgetSerExists(decimal id)
        {
            return _context.HrEmpBudgetSers.Any(e => e.FCompanyId == id);
        }
    }
}
