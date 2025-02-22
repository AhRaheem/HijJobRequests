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
    public class HrEmpExperienceController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpExperienceController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpExperience
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrEmpExperience>>> GetHrEmpExperiences()
        {
            return await _context.HrEmpExperiences.ToListAsync();
        }

        // GET: api/HrEmpExperience/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpExperience>> GetHrEmpExperience(decimal id)
        {
            var hrempexperience = await _context.HrEmpExperiences.FindAsync(id);

            if (hrempexperience == null)
            {
                return NotFound();
            }

            return hrempexperience;
        }

        // PUT: api/HrEmpExperience/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpExperience(decimal id, HrEmpExperience hrempexperience)
        {
            if (id != hrempexperience.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempexperience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpExperienceExists(id))
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

        // POST: api/HrEmpExperience
        [HttpPost]
        public async Task<ActionResult<HrEmpExperience>> PostHrEmpExperience(HrEmpExperience hrempexperience)
        {
            _context.HrEmpExperiences.Add(hrempexperience);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpExperience", new { id = hrempexperience.FCompanyId }, hrempexperience);
        }

        // DELETE: api/HrEmpExperience/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpExperience(decimal id)
        {
            var hrempexperience = await _context.HrEmpExperiences.FindAsync(id);
            if (hrempexperience == null)
            {
                return NotFound();
            }

            _context.HrEmpExperiences.Remove(hrempexperience);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpExperienceExists(decimal id)
        {
            return _context.HrEmpExperiences.Any(e => e.FCompanyId == id);
        }
    }
}
