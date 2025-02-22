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
    public class AppUserController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppUserController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers()
        {
            return await _context.AppUsers.ToListAsync();
        }

        // GET: api/AppUser/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(decimal id)
        {
            var appuser = await _context.AppUsers.FindAsync(id);

            if (appuser == null)
            {
                return NotFound();
            }

            return appuser;
        }

        // PUT: api/AppUser/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(decimal id, AppUser appuser)
        {
            if (id != appuser.FUserId)
            {
                return BadRequest();
            }

            _context.Entry(appuser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(id))
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

        // POST: api/AppUser
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser appuser)
        {
            _context.AppUsers.Add(appuser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppUser", new { id = appuser.FUserId }, appuser);
        }

        // DELETE: api/AppUser/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(decimal id)
        {
            var appuser = await _context.AppUsers.FindAsync(id);
            if (appuser == null)
            {
                return NotFound();
            }

            _context.AppUsers.Remove(appuser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppUserExists(decimal id)
        {
            return _context.AppUsers.Any(e => e.FUserId == id);
        }
    }
}
