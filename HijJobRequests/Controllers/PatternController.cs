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
    public class PatternController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public PatternController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/Pattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pattern>>> GetPatterns()
        {
            return await _context.Patterns.ToListAsync();
        }

        // GET: api/Pattern/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Pattern>> GetPattern(int id)
        {
            var pattern = await _context.Patterns.FindAsync(id);

            if (pattern == null)
            {
                return NotFound();
            }

            return pattern;
        }

        // PUT: api/Pattern/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPattern(int id, Pattern pattern)
        {
            if (id != pattern.Id)
            {
                return BadRequest();
            }

            _context.Entry(pattern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatternExists(id))
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

        // POST: api/Pattern
        [HttpPost]
        public async Task<ActionResult<Pattern>> PostPattern(Pattern pattern)
        {
            _context.Patterns.Add(pattern);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPattern", new { id = pattern.Id }, pattern);
        }

        // DELETE: api/Pattern/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePattern(int id)
        {
            var pattern = await _context.Patterns.FindAsync(id);
            if (pattern == null)
            {
                return NotFound();
            }

            _context.Patterns.Remove(pattern);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatternExists(int id)
        {
            return _context.Patterns.Any(e => e.Id == id);
        }
    }
}
