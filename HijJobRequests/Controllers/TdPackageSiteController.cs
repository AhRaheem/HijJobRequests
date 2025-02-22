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
    public class TdPackageSiteController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdPackageSiteController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdPackageSite
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdPackageSite>>> GetTdPackageSites()
        {
            return await _context.TdPackageSites.ToListAsync();
        }

        // GET: api/TdPackageSite/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdPackageSite>> GetTdPackageSite(int id)
        {
            var tdpackagesite = await _context.TdPackageSites.FindAsync(id);

            if (tdpackagesite == null)
            {
                return NotFound();
            }

            return tdpackagesite;
        }

        // PUT: api/TdPackageSite/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdPackageSite(int id, TdPackageSite tdpackagesite)
        {
            if (id != tdpackagesite.FSiteNo)
            {
                return BadRequest();
            }

            _context.Entry(tdpackagesite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdPackageSiteExists(id))
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

        // POST: api/TdPackageSite
        [HttpPost]
        public async Task<ActionResult<TdPackageSite>> PostTdPackageSite(TdPackageSite tdpackagesite)
        {
            _context.TdPackageSites.Add(tdpackagesite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdPackageSite", new { id = tdpackagesite.FSiteNo }, tdpackagesite);
        }

        // DELETE: api/TdPackageSite/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdPackageSite(int id)
        {
            var tdpackagesite = await _context.TdPackageSites.FindAsync(id);
            if (tdpackagesite == null)
            {
                return NotFound();
            }

            _context.TdPackageSites.Remove(tdpackagesite);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdPackageSiteExists(int id)
        {
            return _context.TdPackageSites.Any(e => e.FSiteNo == id);
        }
    }
}
