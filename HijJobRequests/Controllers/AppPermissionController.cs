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
    public class AppPermissionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppPermissionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppPermission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppPermission>>> GetAppPermissions()
        {
            return await _context.AppPermissions.ToListAsync();
        }

        // GET: api/AppPermission/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppPermission>> GetAppPermission(decimal id)
        {
            var apppermission = await _context.AppPermissions.FindAsync(id);

            if (apppermission == null)
            {
                return NotFound();
            }

            return apppermission;
        }

        // PUT: api/AppPermission/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppPermission(decimal id, AppPermission apppermission)
        {
            if (id != apppermission.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(apppermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppPermissionExists(id))
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

        // POST: api/AppPermission
        [HttpPost]
        public async Task<ActionResult<AppPermission>> PostAppPermission(AppPermission apppermission)
        {
            _context.AppPermissions.Add(apppermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppPermission", new { id = apppermission.FCompanyId }, apppermission);
        }

        // DELETE: api/AppPermission/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppPermission(decimal id)
        {
            var apppermission = await _context.AppPermissions.FindAsync(id);
            if (apppermission == null)
            {
                return NotFound();
            }

            _context.AppPermissions.Remove(apppermission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppPermissionExists(decimal id)
        {
            return _context.AppPermissions.Any(e => e.FCompanyId == id);
        }
    }
}
