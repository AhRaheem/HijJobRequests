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
    public class RolePermissionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public RolePermissionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/RolePermission
        [HttpGet]
        public async Task<ActionResult<PaginationList<RolePermission>>> GetRolePermissions([FromQuery]PaginationParams paginationParams)
        {
            return await _context.RolePermissions.GetPagedAsync(paginationParams);
        }

        // GET: api/RolePermission/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RolePermission>> GetRolePermission(int id)
        {
            var rolepermission = await _context.RolePermissions.FindAsync(id);

            if (rolepermission == null)
            {
                return NotFound();
            }

            return rolepermission;
        }

        // PUT: api/RolePermission/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRolePermission(int id, RolePermission rolepermission)
        {
            if (id != rolepermission.Id)
            {
                return BadRequest();
            }

            _context.Entry(rolepermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolePermissionExists(id))
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

        // POST: api/RolePermission
        [HttpPost]
        public async Task<ActionResult<RolePermission>> PostRolePermission(RolePermission rolepermission)
        {
            _context.RolePermissions.Add(rolepermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRolePermission", new { id = rolepermission.Id }, rolepermission);
        }

        // DELETE: api/RolePermission/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRolePermission(int id)
        {
            var rolepermission = await _context.RolePermissions.FindAsync(id);
            if (rolepermission == null)
            {
                return NotFound();
            }

            _context.RolePermissions.Remove(rolepermission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolePermissionExists(int id)
        {
            return _context.RolePermissions.Any(e => e.Id == id);
        }
    }
}
