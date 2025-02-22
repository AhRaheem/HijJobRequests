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
    public class TdTransportController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdTransportController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdTransport
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdTransport>>> GetTdTransports()
        {
            return await _context.TdTransports.ToListAsync();
        }

        // GET: api/TdTransport/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdTransport>> GetTdTransport(int id)
        {
            var tdtransport = await _context.TdTransports.FindAsync(id);

            if (tdtransport == null)
            {
                return NotFound();
            }

            return tdtransport;
        }

        // PUT: api/TdTransport/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdTransport(int id, TdTransport tdtransport)
        {
            if (id != tdtransport.FTransportNo)
            {
                return BadRequest();
            }

            _context.Entry(tdtransport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdTransportExists(id))
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

        // POST: api/TdTransport
        [HttpPost]
        public async Task<ActionResult<TdTransport>> PostTdTransport(TdTransport tdtransport)
        {
            _context.TdTransports.Add(tdtransport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdTransport", new { id = tdtransport.FTransportNo }, tdtransport);
        }

        // DELETE: api/TdTransport/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdTransport(int id)
        {
            var tdtransport = await _context.TdTransports.FindAsync(id);
            if (tdtransport == null)
            {
                return NotFound();
            }

            _context.TdTransports.Remove(tdtransport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdTransportExists(int id)
        {
            return _context.TdTransports.Any(e => e.FTransportNo == id);
        }
    }
}
