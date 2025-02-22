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
    public class TdJobController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdJobController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdJob
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdJob>>> GetTdJobs()
        {
            return await _context.TdJobs.ToListAsync();
        }

        // GET: api/TdJob/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdJob>> GetTdJob(int id)
        {
            var tdjob = await _context.TdJobs.FindAsync(id);

            if (tdjob == null)
            {
                return NotFound();
            }

            return tdjob;
        }

        // PUT: api/TdJob/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdJob(int id, TdJob tdjob)
        {
            if (id != tdjob.FJobNo)
            {
                return BadRequest();
            }

            _context.Entry(tdjob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdJobExists(id))
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

        // POST: api/TdJob
        [HttpPost]
        public async Task<ActionResult<TdJob>> PostTdJob(TdJob tdjob)
        {
            _context.TdJobs.Add(tdjob);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdJob", new { id = tdjob.FJobNo }, tdjob);
        }

        // DELETE: api/TdJob/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdJob(int id)
        {
            var tdjob = await _context.TdJobs.FindAsync(id);
            if (tdjob == null)
            {
                return NotFound();
            }

            _context.TdJobs.Remove(tdjob);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdJobExists(int id)
        {
            return _context.TdJobs.Any(e => e.FJobNo == id);
        }
    }
}
