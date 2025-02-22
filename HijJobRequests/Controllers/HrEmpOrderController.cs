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
    public class HrEmpOrderController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpOrderController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpOrder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrEmpOrder>>> GetHrEmpOrders()
        {
            return await _context.HrEmpOrders.ToListAsync();
        }

        // GET: api/HrEmpOrder/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpOrder>> GetHrEmpOrder(decimal id)
        {
            var hremporder = await _context.HrEmpOrders.FindAsync(id);

            if (hremporder == null)
            {
                return NotFound();
            }

            return hremporder;
        }

        // PUT: api/HrEmpOrder/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpOrder(decimal id, HrEmpOrder hremporder)
        {
            if (id != hremporder.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hremporder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpOrderExists(id))
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

        // POST: api/HrEmpOrder
        [HttpPost]
        public async Task<ActionResult<HrEmpOrder>> PostHrEmpOrder(HrEmpOrder hremporder)
        {
            _context.HrEmpOrders.Add(hremporder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpOrder", new { id = hremporder.FCompanyId }, hremporder);
        }

        // DELETE: api/HrEmpOrder/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpOrder(decimal id)
        {
            var hremporder = await _context.HrEmpOrders.FindAsync(id);
            if (hremporder == null)
            {
                return NotFound();
            }

            _context.HrEmpOrders.Remove(hremporder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpOrderExists(decimal id)
        {
            return _context.HrEmpOrders.Any(e => e.FCompanyId == id);
        }
    }
}
