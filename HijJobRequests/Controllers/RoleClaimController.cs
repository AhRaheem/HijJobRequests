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
    public class RoleClaimController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public RoleClaimController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/RoleClaim
        [HttpGet]
        public async Task<ActionResult<PaginationList<RoleClaim>>> GetRoleClaims([FromQuery]PaginationParams paginationParams)
        {
            return await _context.RoleClaims.GetPagedAsync(paginationParams);
        }

        // GET: api/RoleClaim/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleClaim>> GetRoleClaim(int id)
        {
            var roleclaim = await _context.RoleClaims.FindAsync(id);

            if (roleclaim == null)
            {
                return NotFound();
            }

            return roleclaim;
        }

        // PUT: api/RoleClaim/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleClaim(int id, RoleClaim roleclaim)
        {
            if (id != roleclaim.Id)
            {
                return BadRequest();
            }

            _context.Entry(roleclaim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleClaimExists(id))
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

        // POST: api/RoleClaim
        [HttpPost]
        public async Task<ActionResult<RoleClaim>> PostRoleClaim(RoleClaim roleclaim)
        {
            _context.RoleClaims.Add(roleclaim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleClaim", new { id = roleclaim.Id }, roleclaim);
        }

        // DELETE: api/RoleClaim/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleClaim(int id)
        {
            var roleclaim = await _context.RoleClaims.FindAsync(id);
            if (roleclaim == null)
            {
                return NotFound();
            }

            _context.RoleClaims.Remove(roleclaim);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleClaimExists(int id)
        {
            return _context.RoleClaims.Any(e => e.Id == id);
        }
    }
}
