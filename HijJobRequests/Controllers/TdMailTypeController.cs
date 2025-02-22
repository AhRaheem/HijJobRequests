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
    public class TdMailTypeController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdMailTypeController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdMailType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdMailType>>> GetTdMailTypes()
        {
            return await _context.TdMailTypes.ToListAsync();
        }

        // GET: api/TdMailType/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdMailType>> GetTdMailType(int id)
        {
            var tdmailtype = await _context.TdMailTypes.FindAsync(id);

            if (tdmailtype == null)
            {
                return NotFound();
            }

            return tdmailtype;
        }

        // PUT: api/TdMailType/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdMailType(int id, TdMailType tdmailtype)
        {
            if (id != tdmailtype.FMealTypeNo)
            {
                return BadRequest();
            }

            _context.Entry(tdmailtype).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdMailTypeExists(id))
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

        // POST: api/TdMailType
        [HttpPost]
        public async Task<ActionResult<TdMailType>> PostTdMailType(TdMailType tdmailtype)
        {
            _context.TdMailTypes.Add(tdmailtype);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdMailType", new { id = tdmailtype.FMealTypeNo }, tdmailtype);
        }

        // DELETE: api/TdMailType/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdMailType(int id)
        {
            var tdmailtype = await _context.TdMailTypes.FindAsync(id);
            if (tdmailtype == null)
            {
                return NotFound();
            }

            _context.TdMailTypes.Remove(tdmailtype);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdMailTypeExists(int id)
        {
            return _context.TdMailTypes.Any(e => e.FMealTypeNo == id);
        }
    }
}
