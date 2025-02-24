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
    public class TdCenterController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdCenterController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdCenter
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdCenter>>> GetTdCenters([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdCenters.GetPagedAsync(paginationParams);
        }

        // GET: api/TdCenter/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdCenter>> GetTdCenter(decimal id)
        {
            var tdcenter = await _context.TdCenters.FindAsync(id);

            if (tdcenter == null)
            {
                return NotFound();
            }

            return tdcenter;
        }

        // PUT: api/TdCenter/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdCenter(decimal id, TdCenter tdcenter)
        {
            if (id != tdcenter.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdcenter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdCenterExists(id))
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

        // POST: api/TdCenter
        [HttpPost]
        public async Task<ActionResult<TdCenter>> PostTdCenter(TdCenter tdcenter)
        {
            _context.TdCenters.Add(tdcenter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdCenter", new { id = tdcenter.FCompanyId }, tdcenter);
        }

        // DELETE: api/TdCenter/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdCenter(decimal id)
        {
            var tdcenter = await _context.TdCenters.FindAsync(id);
            if (tdcenter == null)
            {
                return NotFound();
            }

            _context.TdCenters.Remove(tdcenter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdCenterExists(decimal id)
        {
            return _context.TdCenters.Any(e => e.FCompanyId == id);
        }
    }
}
