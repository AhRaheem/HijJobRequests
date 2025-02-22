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
    public class ChFromElementController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChFromElementController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChFromElement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChFromElement>>> GetChFromElements()
        {
            return await _context.ChFromElements.ToListAsync();
        }

        // GET: api/ChFromElement/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChFromElement>> GetChFromElement(decimal id)
        {
            var chfromelement = await _context.ChFromElements.FindAsync(id);

            if (chfromelement == null)
            {
                return NotFound();
            }

            return chfromelement;
        }

        // PUT: api/ChFromElement/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChFromElement(decimal id, ChFromElement chfromelement)
        {
            if (id != chfromelement.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chfromelement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChFromElementExists(id))
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

        // POST: api/ChFromElement
        [HttpPost]
        public async Task<ActionResult<ChFromElement>> PostChFromElement(ChFromElement chfromelement)
        {
            _context.ChFromElements.Add(chfromelement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChFromElement", new { id = chfromelement.FCompanyId }, chfromelement);
        }

        // DELETE: api/ChFromElement/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChFromElement(decimal id)
        {
            var chfromelement = await _context.ChFromElements.FindAsync(id);
            if (chfromelement == null)
            {
                return NotFound();
            }

            _context.ChFromElements.Remove(chfromelement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChFromElementExists(decimal id)
        {
            return _context.ChFromElements.Any(e => e.FCompanyId == id);
        }
    }
}
