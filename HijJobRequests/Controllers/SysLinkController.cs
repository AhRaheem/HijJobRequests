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
    public class SysLinkController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SysLinkController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/SysLink
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysLink>>> GetSysLinks()
        {
            return await _context.SysLinks.ToListAsync();
        }

        // GET: api/SysLink/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SysLink>> GetSysLink(int id)
        {
            var syslink = await _context.SysLinks.FindAsync(id);

            if (syslink == null)
            {
                return NotFound();
            }

            return syslink;
        }

        // PUT: api/SysLink/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysLink(int id, SysLink syslink)
        {
            if (id != syslink.FLinkNo)
            {
                return BadRequest();
            }

            _context.Entry(syslink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysLinkExists(id))
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

        // POST: api/SysLink
        [HttpPost]
        public async Task<ActionResult<SysLink>> PostSysLink(SysLink syslink)
        {
            _context.SysLinks.Add(syslink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysLink", new { id = syslink.FLinkNo }, syslink);
        }

        // DELETE: api/SysLink/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysLink(int id)
        {
            var syslink = await _context.SysLinks.FindAsync(id);
            if (syslink == null)
            {
                return NotFound();
            }

            _context.SysLinks.Remove(syslink);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysLinkExists(int id)
        {
            return _context.SysLinks.Any(e => e.FLinkNo == id);
        }
    }
}
