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
    public class AppPageController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppPageController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppPage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppPage>>> GetAppPages()
        {
            return await _context.AppPages.ToListAsync();
        }

        // GET: api/AppPage/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppPage>> GetAppPage(decimal id)
        {
            var apppage = await _context.AppPages.FindAsync(id);

            if (apppage == null)
            {
                return NotFound();
            }

            return apppage;
        }

        // PUT: api/AppPage/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppPage(decimal id, AppPage apppage)
        {
            if (id != apppage.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(apppage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppPageExists(id))
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

        // POST: api/AppPage
        [HttpPost]
        public async Task<ActionResult<AppPage>> PostAppPage(AppPage apppage)
        {
            _context.AppPages.Add(apppage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppPage", new { id = apppage.FCompanyId }, apppage);
        }

        // DELETE: api/AppPage/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppPage(decimal id)
        {
            var apppage = await _context.AppPages.FindAsync(id);
            if (apppage == null)
            {
                return NotFound();
            }

            _context.AppPages.Remove(apppage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppPageExists(decimal id)
        {
            return _context.AppPages.Any(e => e.FCompanyId == id);
        }
    }
}
