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
    public class ChContractRequestController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChContractRequestController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChContractRequest
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChContractRequest>>> GetChContractRequests()
        {
            return await _context.ChContractRequests.ToListAsync();
        }

        // GET: api/ChContractRequest/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChContractRequest>> GetChContractRequest(decimal id)
        {
            var chcontractrequest = await _context.ChContractRequests.FindAsync(id);

            if (chcontractrequest == null)
            {
                return NotFound();
            }

            return chcontractrequest;
        }

        // PUT: api/ChContractRequest/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChContractRequest(decimal id, ChContractRequest chcontractrequest)
        {
            if (id != chcontractrequest.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chcontractrequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChContractRequestExists(id))
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

        // POST: api/ChContractRequest
        [HttpPost]
        public async Task<ActionResult<ChContractRequest>> PostChContractRequest(ChContractRequest chcontractrequest)
        {
            _context.ChContractRequests.Add(chcontractrequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChContractRequest", new { id = chcontractrequest.FCompanyId }, chcontractrequest);
        }

        // DELETE: api/ChContractRequest/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChContractRequest(decimal id)
        {
            var chcontractrequest = await _context.ChContractRequests.FindAsync(id);
            if (chcontractrequest == null)
            {
                return NotFound();
            }

            _context.ChContractRequests.Remove(chcontractrequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChContractRequestExists(decimal id)
        {
            return _context.ChContractRequests.Any(e => e.FCompanyId == id);
        }
    }
}
