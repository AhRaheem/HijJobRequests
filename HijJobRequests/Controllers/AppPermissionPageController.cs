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
    public class AppPermissionPageController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppPermissionPageController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppPermissionPage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppPermissionPage>>> GetAppPermissionPages()
        {
            return await _context.AppPermissionPages.ToListAsync();
        }

        // GET: api/AppPermissionPage/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppPermissionPage>> GetAppPermissionPage(decimal id)
        {
            var apppermissionpage = await _context.AppPermissionPages.FindAsync(id);

            if (apppermissionpage == null)
            {
                return NotFound();
            }

            return apppermissionpage;
        }

        // PUT: api/AppPermissionPage/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppPermissionPage(decimal id, AppPermissionPage apppermissionpage)
        {
            if (id != apppermissionpage.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(apppermissionpage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppPermissionPageExists(id))
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

        // POST: api/AppPermissionPage
        [HttpPost]
        public async Task<ActionResult<AppPermissionPage>> PostAppPermissionPage(AppPermissionPage apppermissionpage)
        {
            _context.AppPermissionPages.Add(apppermissionpage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppPermissionPage", new { id = apppermissionpage.FCompanyId }, apppermissionpage);
        }

        // DELETE: api/AppPermissionPage/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppPermissionPage(decimal id)
        {
            var apppermissionpage = await _context.AppPermissionPages.FindAsync(id);
            if (apppermissionpage == null)
            {
                return NotFound();
            }

            _context.AppPermissionPages.Remove(apppermissionpage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppPermissionPageExists(decimal id)
        {
            return _context.AppPermissionPages.Any(e => e.FCompanyId == id);
        }
    }
}
