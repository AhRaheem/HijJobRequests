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
    public class HrEmpOrderCareController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpOrderCareController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpOrderCare
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrEmpOrderCare>>> GetHrEmpOrderCares()
        {
            return await _context.HrEmpOrderCares.ToListAsync();
        }

        // GET: api/HrEmpOrderCare/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpOrderCare>> GetHrEmpOrderCare(decimal id)
        {
            var hrempordercare = await _context.HrEmpOrderCares.FindAsync(id);

            if (hrempordercare == null)
            {
                return NotFound();
            }

            return hrempordercare;
        }

        // PUT: api/HrEmpOrderCare/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpOrderCare(decimal id, HrEmpOrderCare hrempordercare)
        {
            if (id != hrempordercare.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempordercare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpOrderCareExists(id))
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

        // POST: api/HrEmpOrderCare
        [HttpPost]
        public async Task<ActionResult<HrEmpOrderCare>> PostHrEmpOrderCare(HrEmpOrderCare hrempordercare)
        {
            _context.HrEmpOrderCares.Add(hrempordercare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpOrderCare", new { id = hrempordercare.FCompanyId }, hrempordercare);
        }

        // DELETE: api/HrEmpOrderCare/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpOrderCare(decimal id)
        {
            var hrempordercare = await _context.HrEmpOrderCares.FindAsync(id);
            if (hrempordercare == null)
            {
                return NotFound();
            }

            _context.HrEmpOrderCares.Remove(hrempordercare);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpOrderCareExists(decimal id)
        {
            return _context.HrEmpOrderCares.Any(e => e.FCompanyId == id);
        }
    }
}
