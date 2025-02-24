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
    public class TdPictController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdPictController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdPict
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdPict>>> GetTdPicts([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdPicts.GetPagedAsync(paginationParams);
        }

        // GET: api/TdPict/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdPict>> GetTdPict(int id)
        {
            var tdpict = await _context.TdPicts.FindAsync(id);

            if (tdpict == null)
            {
                return NotFound();
            }

            return tdpict;
        }

        // PUT: api/TdPict/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdPict(int id, TdPict tdpict)
        {
            if (id != tdpict.FPictNo)
            {
                return BadRequest();
            }

            _context.Entry(tdpict).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdPictExists(id))
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

        // POST: api/TdPict
        [HttpPost]
        public async Task<ActionResult<TdPict>> PostTdPict(TdPict tdpict)
        {
            _context.TdPicts.Add(tdpict);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdPict", new { id = tdpict.FPictNo }, tdpict);
        }

        // DELETE: api/TdPict/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdPict(int id)
        {
            var tdpict = await _context.TdPicts.FindAsync(id);
            if (tdpict == null)
            {
                return NotFound();
            }

            _context.TdPicts.Remove(tdpict);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdPictExists(int id)
        {
            return _context.TdPicts.Any(e => e.FPictNo == id);
        }
    }
}
