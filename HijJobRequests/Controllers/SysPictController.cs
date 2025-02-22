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
    public class SysPictController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SysPictController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/SysPict
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysPict>>> GetSysPicts()
        {
            return await _context.SysPicts.ToListAsync();
        }

        // GET: api/SysPict/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SysPict>> GetSysPict(int id)
        {
            var syspict = await _context.SysPicts.FindAsync(id);

            if (syspict == null)
            {
                return NotFound();
            }

            return syspict;
        }

        // PUT: api/SysPict/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysPict(int id, SysPict syspict)
        {
            if (id != syspict.FSerNo)
            {
                return BadRequest();
            }

            _context.Entry(syspict).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysPictExists(id))
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

        // POST: api/SysPict
        [HttpPost]
        public async Task<ActionResult<SysPict>> PostSysPict(SysPict syspict)
        {
            _context.SysPicts.Add(syspict);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysPict", new { id = syspict.FSerNo }, syspict);
        }

        // DELETE: api/SysPict/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysPict(int id)
        {
            var syspict = await _context.SysPicts.FindAsync(id);
            if (syspict == null)
            {
                return NotFound();
            }

            _context.SysPicts.Remove(syspict);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysPictExists(int id)
        {
            return _context.SysPicts.Any(e => e.FSerNo == id);
        }
    }
}
