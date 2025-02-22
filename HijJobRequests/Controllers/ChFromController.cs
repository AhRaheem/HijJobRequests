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
    public class ChFromController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChFromController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChFrom
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChFrom>>> GetChFroms()
        {
            return await _context.ChFroms.ToListAsync();
        }

        // GET: api/ChFrom/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChFrom>> GetChFrom(decimal id)
        {
            var chfrom = await _context.ChFroms.FindAsync(id);

            if (chfrom == null)
            {
                return NotFound();
            }

            return chfrom;
        }

        // PUT: api/ChFrom/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChFrom(decimal id, ChFrom chfrom)
        {
            if (id != chfrom.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chfrom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChFromExists(id))
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

        // POST: api/ChFrom
        [HttpPost]
        public async Task<ActionResult<ChFrom>> PostChFrom(ChFrom chfrom)
        {
            _context.ChFroms.Add(chfrom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChFrom", new { id = chfrom.FCompanyId }, chfrom);
        }

        // DELETE: api/ChFrom/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChFrom(decimal id)
        {
            var chfrom = await _context.ChFroms.FindAsync(id);
            if (chfrom == null)
            {
                return NotFound();
            }

            _context.ChFroms.Remove(chfrom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChFromExists(decimal id)
        {
            return _context.ChFroms.Any(e => e.FCompanyId == id);
        }
    }
}
