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
    public class TdOrderStatusController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdOrderStatusController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdOrderStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdOrderStatus>>> GetTdOrderStatuss()
        {
            return await _context.TdOrderStatuses.ToListAsync();
        }

        // GET: api/TdOrderStatus/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdOrderStatus>> GetTdOrderStatus(int id)
        {
            var tdorderstatus = await _context.TdOrderStatuses.FindAsync(id);

            if (tdorderstatus == null)
            {
                return NotFound();
            }

            return tdorderstatus;
        }

        // PUT: api/TdOrderStatus/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdOrderStatus(int id, TdOrderStatus tdorderstatus)
        {
            if (id != tdorderstatus.FOrderStatusNo)
            {
                return BadRequest();
            }

            _context.Entry(tdorderstatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdOrderStatusExists(id))
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

        // POST: api/TdOrderStatus
        [HttpPost]
        public async Task<ActionResult<TdOrderStatus>> PostTdOrderStatus(TdOrderStatus tdorderstatus)
        {
            _context.TdOrderStatuses.Add(tdorderstatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdOrderStatus", new { id = tdorderstatus.FOrderStatusNo }, tdorderstatus);
        }

        // DELETE: api/TdOrderStatus/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdOrderStatus(int id)
        {
            var tdorderstatus = await _context.TdOrderStatuses.FindAsync(id);
            if (tdorderstatus == null)
            {
                return NotFound();
            }

            _context.TdOrderStatuses.Remove(tdorderstatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdOrderStatusExists(int id)
        {
            return _context.TdOrderStatuses.Any(e => e.FOrderStatusNo == id);
        }
    }
}
