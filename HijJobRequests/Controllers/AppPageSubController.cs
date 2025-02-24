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
    public class AppPageSubController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppPageSubController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppPageSub
        [HttpGet]
        public async Task<ActionResult<PaginationList<AppPageSub>>> GetAppPageSubs([FromQuery]PaginationParams paginationParams)
        {
            return await _context.AppPageSubs.GetPagedAsync(paginationParams);
        }

        // GET: api/AppPageSub/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppPageSub>> GetAppPageSub(decimal id)
        {
            var apppagesub = await _context.AppPageSubs.FindAsync(id);

            if (apppagesub == null)
            {
                return NotFound();
            }

            return apppagesub;
        }

        // PUT: api/AppPageSub/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppPageSub(decimal id, AppPageSub apppagesub)
        {
            if (id != apppagesub.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(apppagesub).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppPageSubExists(id))
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

        // POST: api/AppPageSub
        [HttpPost]
        public async Task<ActionResult<AppPageSub>> PostAppPageSub(AppPageSub apppagesub)
        {
            _context.AppPageSubs.Add(apppagesub);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppPageSub", new { id = apppagesub.FCompanyId }, apppagesub);
        }

        // DELETE: api/AppPageSub/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppPageSub(decimal id)
        {
            var apppagesub = await _context.AppPageSubs.FindAsync(id);
            if (apppagesub == null)
            {
                return NotFound();
            }

            _context.AppPageSubs.Remove(apppagesub);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppPageSubExists(decimal id)
        {
            return _context.AppPageSubs.Any(e => e.FCompanyId == id);
        }
    }
}
