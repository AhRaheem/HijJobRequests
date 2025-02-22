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
    public class TdCountryController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdCountryController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdCountry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdCountry>>> GetTdCountrys()
        {
            return await _context.TdCountries.ToListAsync();
        }

        // GET: api/TdCountry/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdCountry>> GetTdCountry(int id)
        {
            var tdcountry = await _context.TdCountries.FindAsync(id);

            if (tdcountry == null)
            {
                return NotFound();
            }

            return tdcountry;
        }

        // PUT: api/TdCountry/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdCountry(int id, TdCountry tdcountry)
        {
            if (id != tdcountry.FCountryNo)
            {
                return BadRequest();
            }

            _context.Entry(tdcountry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdCountryExists(id))
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

        // POST: api/TdCountry
        [HttpPost]
        public async Task<ActionResult<TdCountry>> PostTdCountry(TdCountry tdcountry)
        {
            _context.TdCountries.Add(tdcountry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdCountry", new { id = tdcountry.FCountryNo }, tdcountry);
        }

        // DELETE: api/TdCountry/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdCountry(int id)
        {
            var tdcountry = await _context.TdCountries.FindAsync(id);
            if (tdcountry == null)
            {
                return NotFound();
            }

            _context.TdCountries.Remove(tdcountry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdCountryExists(int id)
        {
            return _context.TdCountries.Any(e => e.FCountryNo == id);
        }
    }
}
