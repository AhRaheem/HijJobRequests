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
    public class PbcatcolController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public PbcatcolController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/Pbcatcol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pbcatcol>>> GetPbcatcols()
        {
            return await _context.Pbcatcols.ToListAsync();
        }

        // GET: api/Pbcatcol/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Pbcatcol>> GetPbcatcol(int id)
        {
            var pbcatcol = await _context.Pbcatcols.FindAsync(id);

            if (pbcatcol == null)
            {
                return NotFound();
            }

            return pbcatcol;
        }

        // PUT: api/Pbcatcol/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPbcatcol(int id, Pbcatcol pbcatcol)
        {
            if (id != pbcatcol.PbcTid)
            {
                return BadRequest();
            }

            _context.Entry(pbcatcol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PbcatcolExists(id))
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

        // POST: api/Pbcatcol
        [HttpPost]
        public async Task<ActionResult<Pbcatcol>> PostPbcatcol(Pbcatcol pbcatcol)
        {
            _context.Pbcatcols.Add(pbcatcol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPbcatcol", new { id = pbcatcol.PbcTid }, pbcatcol);
        }

        // DELETE: api/Pbcatcol/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePbcatcol(int id)
        {
            var pbcatcol = await _context.Pbcatcols.FindAsync(id);
            if (pbcatcol == null)
            {
                return NotFound();
            }

            _context.Pbcatcols.Remove(pbcatcol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PbcatcolExists(int id)
        {
            return _context.Pbcatcols.Any(e => e.PbcTid == id);
        }
    }
}
