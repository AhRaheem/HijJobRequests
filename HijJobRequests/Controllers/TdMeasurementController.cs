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
    public class TdMeasurementController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdMeasurementController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdMeasurement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdMeasurement>>> GetTdMeasurements()
        {
            return await _context.TdMeasurements.ToListAsync();
        }

        // GET: api/TdMeasurement/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdMeasurement>> GetTdMeasurement(decimal id)
        {
            var tdmeasurement = await _context.TdMeasurements.FindAsync(id);

            if (tdmeasurement == null)
            {
                return NotFound();
            }

            return tdmeasurement;
        }

        // PUT: api/TdMeasurement/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdMeasurement(decimal id, TdMeasurement tdmeasurement)
        {
            if (id != tdmeasurement.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdmeasurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdMeasurementExists(id))
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

        // POST: api/TdMeasurement
        [HttpPost]
        public async Task<ActionResult<TdMeasurement>> PostTdMeasurement(TdMeasurement tdmeasurement)
        {
            _context.TdMeasurements.Add(tdmeasurement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdMeasurement", new { id = tdmeasurement.FCompanyId }, tdmeasurement);
        }

        // DELETE: api/TdMeasurement/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdMeasurement(decimal id)
        {
            var tdmeasurement = await _context.TdMeasurements.FindAsync(id);
            if (tdmeasurement == null)
            {
                return NotFound();
            }

            _context.TdMeasurements.Remove(tdmeasurement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdMeasurementExists(decimal id)
        {
            return _context.TdMeasurements.Any(e => e.FCompanyId == id);
        }
    }
}
