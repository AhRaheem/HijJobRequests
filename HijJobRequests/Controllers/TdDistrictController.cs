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
    public class TdDistrictController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdDistrictController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdDistrict
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdDistrict>>> GetTdDistricts()
        {
            return await _context.TdDistricts.ToListAsync();
        }

        // GET: api/TdDistrict/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdDistrict>> GetTdDistrict(int id)
        {
            var tddistrict = await _context.TdDistricts.FindAsync(id);

            if (tddistrict == null)
            {
                return NotFound();
            }

            return tddistrict;
        }

        // PUT: api/TdDistrict/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdDistrict(int id, TdDistrict tddistrict)
        {
            if (id != tddistrict.FDistrictNo)
            {
                return BadRequest();
            }

            _context.Entry(tddistrict).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdDistrictExists(id))
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

        // POST: api/TdDistrict
        [HttpPost]
        public async Task<ActionResult<TdDistrict>> PostTdDistrict(TdDistrict tddistrict)
        {
            _context.TdDistricts.Add(tddistrict);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdDistrict", new { id = tddistrict.FDistrictNo }, tddistrict);
        }

        // DELETE: api/TdDistrict/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdDistrict(int id)
        {
            var tddistrict = await _context.TdDistricts.FindAsync(id);
            if (tddistrict == null)
            {
                return NotFound();
            }

            _context.TdDistricts.Remove(tddistrict);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdDistrictExists(int id)
        {
            return _context.TdDistricts.Any(e => e.FDistrictNo == id);
        }
    }
}
