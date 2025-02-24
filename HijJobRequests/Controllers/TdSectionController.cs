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
    public class TdSectionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdSectionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdSection
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdSection>>> GetTdSections([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdSections.GetPagedAsync(paginationParams);
        }

        // GET: api/TdSection/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdSection>> GetTdSection(decimal id)
        {
            var tdsection = await _context.TdSections.FindAsync(id);

            if (tdsection == null)
            {
                return NotFound();
            }

            return tdsection;
        }

        // PUT: api/TdSection/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdSection(decimal id, TdSection tdsection)
        {
            if (id != tdsection.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdsection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdSectionExists(id))
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

        // POST: api/TdSection
        [HttpPost]
        public async Task<ActionResult<TdSection>> PostTdSection(TdSection tdsection)
        {
            _context.TdSections.Add(tdsection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdSection", new { id = tdsection.FCompanyId }, tdsection);
        }

        // DELETE: api/TdSection/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdSection(decimal id)
        {
            var tdsection = await _context.TdSections.FindAsync(id);
            if (tdsection == null)
            {
                return NotFound();
            }

            _context.TdSections.Remove(tdsection);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdSectionExists(decimal id)
        {
            return _context.TdSections.Any(e => e.FCompanyId == id);
        }
    }
}
