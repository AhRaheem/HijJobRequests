using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
using Microsoft.AspNetCore.Authorization;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class AppUserPermissionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppUserPermissionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppUserPermission
        [HttpGet]
        public async Task<ActionResult<PaginationList<AppUserPermission>>> GetAppUserPermissions([FromQuery]PaginationParams paginationParams)
        {
            return await _context.AppUserPermissions.GetPagedAsync(paginationParams);
        }

        // GET: api/AppUserPermission/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUserPermission>> GetAppUserPermission(decimal id)
        {
            var appuserpermission = await _context.AppUserPermissions.FindAsync(id);

            if (appuserpermission == null)
            {
                return NotFound();
            }

            return appuserpermission;
        }

        // PUT: api/AppUserPermission/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUserPermission(decimal id, AppUserPermission appuserpermission)
        {
            if (id != appuserpermission.FUserId)
            {
                return BadRequest();
            }

            _context.Entry(appuserpermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserPermissionExists(id))
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

        // POST: api/AppUserPermission
        [HttpPost]
        public async Task<ActionResult<AppUserPermission>> PostAppUserPermission(AppUserPermission appuserpermission)
        {
            _context.AppUserPermissions.Add(appuserpermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppUserPermission", new { id = appuserpermission.FUserId }, appuserpermission);
        }

        // DELETE: api/AppUserPermission/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUserPermission(decimal id)
        {
            var appuserpermission = await _context.AppUserPermissions.FindAsync(id);
            if (appuserpermission == null)
            {
                return NotFound();
            }

            _context.AppUserPermissions.Remove(appuserpermission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppUserPermissionExists(decimal id)
        {
            return _context.AppUserPermissions.Any(e => e.FUserId == id);
        }
    }
}
