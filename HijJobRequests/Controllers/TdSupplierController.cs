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
    public class TdSupplierController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdSupplierController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdSupplier
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdSupplier>>> GetTdSuppliers()
        {
            return await _context.TdSuppliers.ToListAsync();
        }

        // GET: api/TdSupplier/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdSupplier>> GetTdSupplier(int id)
        {
            var tdsupplier = await _context.TdSuppliers.FindAsync(id);

            if (tdsupplier == null)
            {
                return NotFound();
            }

            return tdsupplier;
        }

        // PUT: api/TdSupplier/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdSupplier(int id, TdSupplier tdsupplier)
        {
            if (id != tdsupplier.FIdNo)
            {
                return BadRequest();
            }

            _context.Entry(tdsupplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdSupplierExists(id))
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

        // POST: api/TdSupplier
        [HttpPost]
        public async Task<ActionResult<TdSupplier>> PostTdSupplier(TdSupplier tdsupplier)
        {
            _context.TdSuppliers.Add(tdsupplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdSupplier", new { id = tdsupplier.FIdNo }, tdsupplier);
        }

        // DELETE: api/TdSupplier/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdSupplier(int id)
        {
            var tdsupplier = await _context.TdSuppliers.FindAsync(id);
            if (tdsupplier == null)
            {
                return NotFound();
            }

            _context.TdSuppliers.Remove(tdsupplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdSupplierExists(int id)
        {
            return _context.TdSuppliers.Any(e => e.FIdNo == id);
        }
    }
}
