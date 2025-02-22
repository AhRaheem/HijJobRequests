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
    public class SysCompanyDesignController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SysCompanyDesignController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/SysCompanyDesign
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysCompanyDesign>>> GetSysCompanyDesigns()
        {
            return await _context.SysCompanyDesigns.ToListAsync();
        }

        // GET: api/SysCompanyDesign/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SysCompanyDesign>> GetSysCompanyDesign(decimal id)
        {
            var syscompanydesign = await _context.SysCompanyDesigns.FindAsync(id);

            if (syscompanydesign == null)
            {
                return NotFound();
            }

            return syscompanydesign;
        }

        // PUT: api/SysCompanyDesign/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysCompanyDesign(decimal id, SysCompanyDesign syscompanydesign)
        {
            if (id != syscompanydesign.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(syscompanydesign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysCompanyDesignExists(id))
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

        // POST: api/SysCompanyDesign
        [HttpPost]
        public async Task<ActionResult<SysCompanyDesign>> PostSysCompanyDesign(SysCompanyDesign syscompanydesign)
        {
            _context.SysCompanyDesigns.Add(syscompanydesign);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysCompanyDesign", new { id = syscompanydesign.FCompanyId }, syscompanydesign);
        }

        // DELETE: api/SysCompanyDesign/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysCompanyDesign(decimal id)
        {
            var syscompanydesign = await _context.SysCompanyDesigns.FindAsync(id);
            if (syscompanydesign == null)
            {
                return NotFound();
            }

            _context.SysCompanyDesigns.Remove(syscompanydesign);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysCompanyDesignExists(decimal id)
        {
            return _context.SysCompanyDesigns.Any(e => e.FCompanyId == id);
        }
    }
}
