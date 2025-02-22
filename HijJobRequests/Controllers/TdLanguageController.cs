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
    public class TdLanguageController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdLanguageController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdLanguage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdLanguage>>> GetTdLanguages()
        {
            return await _context.TdLanguages.ToListAsync();
        }

        // GET: api/TdLanguage/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdLanguage>> GetTdLanguage(int id)
        {
            var tdlanguage = await _context.TdLanguages.FindAsync(id);

            if (tdlanguage == null)
            {
                return NotFound();
            }

            return tdlanguage;
        }

        // PUT: api/TdLanguage/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdLanguage(int id, TdLanguage tdlanguage)
        {
            if (id != tdlanguage.FLanguageNo)
            {
                return BadRequest();
            }

            _context.Entry(tdlanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdLanguageExists(id))
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

        // POST: api/TdLanguage
        [HttpPost]
        public async Task<ActionResult<TdLanguage>> PostTdLanguage(TdLanguage tdlanguage)
        {
            _context.TdLanguages.Add(tdlanguage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdLanguage", new { id = tdlanguage.FLanguageNo }, tdlanguage);
        }

        // DELETE: api/TdLanguage/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdLanguage(int id)
        {
            var tdlanguage = await _context.TdLanguages.FindAsync(id);
            if (tdlanguage == null)
            {
                return NotFound();
            }

            _context.TdLanguages.Remove(tdlanguage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdLanguageExists(int id)
        {
            return _context.TdLanguages.Any(e => e.FLanguageNo == id);
        }
    }
}
