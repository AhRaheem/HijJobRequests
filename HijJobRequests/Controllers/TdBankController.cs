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
    public class TdBankController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdBankController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdBank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdBank>>> GetTdBanks()
        {
            return await _context.TdBanks.ToListAsync();
        }

        // GET: api/TdBank/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdBank>> GetTdBank(int id)
        {
            var tdbank = await _context.TdBanks.FindAsync(id);

            if (tdbank == null)
            {
                return NotFound();
            }

            return tdbank;
        }

        // PUT: api/TdBank/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdBank(int id, TdBank tdbank)
        {
            if (id != tdbank.FBankNo)
            {
                return BadRequest();
            }

            _context.Entry(tdbank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdBankExists(id))
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

        // POST: api/TdBank
        [HttpPost]
        public async Task<ActionResult<TdBank>> PostTdBank(TdBank tdbank)
        {
            _context.TdBanks.Add(tdbank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdBank", new { id = tdbank.FBankNo }, tdbank);
        }

        // DELETE: api/TdBank/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdBank(int id)
        {
            var tdbank = await _context.TdBanks.FindAsync(id);
            if (tdbank == null)
            {
                return NotFound();
            }

            _context.TdBanks.Remove(tdbank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdBankExists(int id)
        {
            return _context.TdBanks.Any(e => e.FBankNo == id);
        }
    }
}
