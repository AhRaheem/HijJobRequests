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
    public class TdMajorController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdMajorController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdMajor
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdMajor>>> GetTdMajors([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdMajors.GetPagedAsync(paginationParams);
        }

        // GET: api/TdMajor/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdMajor>> GetTdMajor(int id)
        {
            var tdmajor = await _context.TdMajors.FindAsync(id);

            if (tdmajor == null)
            {
                return NotFound();
            }

            return tdmajor;
        }

        // PUT: api/TdMajor/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdMajor(int id, TdMajor tdmajor)
        {
            if (id != tdmajor.FMajorNo)
            {
                return BadRequest();
            }

            _context.Entry(tdmajor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdMajorExists(id))
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

        // POST: api/TdMajor
        [HttpPost]
        public async Task<ActionResult<TdMajor>> PostTdMajor(TdMajor tdmajor)
        {
            _context.TdMajors.Add(tdmajor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdMajor", new { id = tdmajor.FMajorNo }, tdmajor);
        }

        // DELETE: api/TdMajor/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdMajor(int id)
        {
            var tdmajor = await _context.TdMajors.FindAsync(id);
            if (tdmajor == null)
            {
                return NotFound();
            }

            _context.TdMajors.Remove(tdmajor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdMajorExists(int id)
        {
            return _context.TdMajors.Any(e => e.FMajorNo == id);
        }
    }
}
