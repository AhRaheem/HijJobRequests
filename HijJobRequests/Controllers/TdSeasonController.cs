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
    public class TdSeasonController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdSeasonController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdSeason
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdSeason>>> GetTdSeasons([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdSeasons.GetPagedAsync(paginationParams);
        }

        // GET: api/TdSeason/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdSeason>> GetTdSeason(int id)
        {
            var tdseason = await _context.TdSeasons.FindAsync(id);

            if (tdseason == null)
            {
                return NotFound();
            }

            return tdseason;
        }

        // PUT: api/TdSeason/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdSeason(int id, TdSeason tdseason)
        {
            if (id != tdseason.FSeasonNo)
            {
                return BadRequest();
            }

            _context.Entry(tdseason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdSeasonExists(id))
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

        // POST: api/TdSeason
        [HttpPost]
        public async Task<ActionResult<TdSeason>> PostTdSeason(TdSeason tdseason)
        {
            _context.TdSeasons.Add(tdseason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdSeason", new { id = tdseason.FSeasonNo }, tdseason);
        }

        // DELETE: api/TdSeason/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdSeason(int id)
        {
            var tdseason = await _context.TdSeasons.FindAsync(id);
            if (tdseason == null)
            {
                return NotFound();
            }

            _context.TdSeasons.Remove(tdseason);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdSeasonExists(int id)
        {
            return _context.TdSeasons.Any(e => e.FSeasonNo == id);
        }
    }
}
