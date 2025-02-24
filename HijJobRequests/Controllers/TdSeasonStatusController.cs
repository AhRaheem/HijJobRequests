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
    public class TdSeasonStatusController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdSeasonStatusController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdSeasonStatus
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdSeasonStatus>>> GetTdSeasonStatuss([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdSeasonStatuses.GetPagedAsync(paginationParams);
        }

        // GET: api/TdSeasonStatus/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdSeasonStatus>> GetTdSeasonStatus(decimal id)
        {
            var tdseasonstatus = await _context.TdSeasonStatuses.FindAsync(id);

            if (tdseasonstatus == null)
            {
                return NotFound();
            }

            return tdseasonstatus;
        }

        // PUT: api/TdSeasonStatus/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdSeasonStatus(decimal id, TdSeasonStatus tdseasonstatus)
        {
            if (id != tdseasonstatus.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdseasonstatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdSeasonStatusExists(id))
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

        // POST: api/TdSeasonStatus
        [HttpPost]
        public async Task<ActionResult<TdSeasonStatus>> PostTdSeasonStatus(TdSeasonStatus tdseasonstatus)
        {
            _context.TdSeasonStatuses.Add(tdseasonstatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdSeasonStatus", new { id = tdseasonstatus.FCompanyId }, tdseasonstatus);
        }

        // DELETE: api/TdSeasonStatus/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdSeasonStatus(decimal id)
        {
            var tdseasonstatus = await _context.TdSeasonStatuses.FindAsync(id);
            if (tdseasonstatus == null)
            {
                return NotFound();
            }

            _context.TdSeasonStatuses.Remove(tdseasonstatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdSeasonStatusExists(decimal id)
        {
            return _context.TdSeasonStatuses.Any(e => e.FCompanyId == id);
        }
    }
}
