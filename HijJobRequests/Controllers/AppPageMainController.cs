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
    public class AppPageMainController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppPageMainController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppPageMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppPageMain>>> GetAppPageMains()
        {
            return await _context.AppPageMains.ToListAsync();
        }

        // GET: api/AppPageMain/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppPageMain>> GetAppPageMain(decimal id)
        {
            var apppagemain = await _context.AppPageMains.FindAsync(id);

            if (apppagemain == null)
            {
                return NotFound();
            }

            return apppagemain;
        }

        // PUT: api/AppPageMain/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppPageMain(decimal id, AppPageMain apppagemain)
        {
            if (id != apppagemain.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(apppagemain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppPageMainExists(id))
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

        // POST: api/AppPageMain
        [HttpPost]
        public async Task<ActionResult<AppPageMain>> PostAppPageMain(AppPageMain apppagemain)
        {
            _context.AppPageMains.Add(apppagemain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppPageMain", new { id = apppagemain.FCompanyId }, apppagemain);
        }

        // DELETE: api/AppPageMain/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppPageMain(decimal id)
        {
            var apppagemain = await _context.AppPageMains.FindAsync(id);
            if (apppagemain == null)
            {
                return NotFound();
            }

            _context.AppPageMains.Remove(apppagemain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppPageMainExists(decimal id)
        {
            return _context.AppPageMains.Any(e => e.FCompanyId == id);
        }
    }
}
