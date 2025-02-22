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
    public class ChOrganizersPerController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChOrganizersPerController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChOrganizersPer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChOrganizersPer>>> GetChOrganizersPers()
        {
            return await _context.ChOrganizersPers.ToListAsync();
        }

        // GET: api/ChOrganizersPer/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChOrganizersPer>> GetChOrganizersPer(int id)
        {
            var chorganizersper = await _context.ChOrganizersPers.FindAsync(id);

            if (chorganizersper == null)
            {
                return NotFound();
            }

            return chorganizersper;
        }

        // PUT: api/ChOrganizersPer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChOrganizersPer(int id, ChOrganizersPer chorganizersper)
        {
            if (id != chorganizersper.FOrganizerNo)
            {
                return BadRequest();
            }

            _context.Entry(chorganizersper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChOrganizersPerExists(id))
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

        // POST: api/ChOrganizersPer
        [HttpPost]
        public async Task<ActionResult<ChOrganizersPer>> PostChOrganizersPer(ChOrganizersPer chorganizersper)
        {
            _context.ChOrganizersPers.Add(chorganizersper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChOrganizersPer", new { id = chorganizersper.FOrganizerNo }, chorganizersper);
        }

        // DELETE: api/ChOrganizersPer/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChOrganizersPer(int id)
        {
            var chorganizersper = await _context.ChOrganizersPers.FindAsync(id);
            if (chorganizersper == null)
            {
                return NotFound();
            }

            _context.ChOrganizersPers.Remove(chorganizersper);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChOrganizersPerExists(int id)
        {
            return _context.ChOrganizersPers.Any(e => e.FOrganizerNo == id);
        }
    }
}
