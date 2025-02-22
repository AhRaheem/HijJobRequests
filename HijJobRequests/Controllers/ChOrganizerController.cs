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
    public class ChOrganizerController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChOrganizerController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChOrganizer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChOrganizer>>> GetChOrganizers()
        {
            return await _context.ChOrganizers.ToListAsync();
        }

        // GET: api/ChOrganizer/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChOrganizer>> GetChOrganizer(int id)
        {
            var chorganizer = await _context.ChOrganizers.FindAsync(id);

            if (chorganizer == null)
            {
                return NotFound();
            }

            return chorganizer;
        }

        // PUT: api/ChOrganizer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChOrganizer(int id, ChOrganizer chorganizer)
        {
            _context.Entry(chorganizer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChOrganizerExists(id))
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

        // POST: api/ChOrganizer
        [HttpPost]
        public async Task<ActionResult<ChOrganizer>> PostChOrganizer(ChOrganizer chorganizer)
        {
            _context.ChOrganizers.Add(chorganizer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChOrganizer", new { id = chorganizer.FOrganizerNo }, chorganizer);
        }

        // DELETE: api/ChOrganizer/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChOrganizer(int id)
        {
            var chorganizer = await _context.ChOrganizers.FindAsync(id);
            if (chorganizer == null)
            {
                return NotFound();
            }

            _context.ChOrganizers.Remove(chorganizer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChOrganizerExists(int id)
        {
            return _context.ChOrganizers.Any(e => e.FOrganizerNo == id);
        }
    }
}
