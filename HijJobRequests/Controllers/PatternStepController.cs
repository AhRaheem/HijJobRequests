using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
using Microsoft.AspNetCore.Authorization;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class PatternStepController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public PatternStepController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/PatternStep
        [HttpGet]
        public async Task<ActionResult<PaginationList<PatternStep>>> GetPatternSteps([FromQuery]PaginationParams paginationParams)
        {
            return await _context.PatternSteps.GetPagedAsync(paginationParams);
        }

        // GET: api/PatternStep/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<PatternStep>> GetPatternStep(int id)
        {
            var patternstep = await _context.PatternSteps.FindAsync(id);

            if (patternstep == null)
            {
                return NotFound();
            }

            return patternstep;
        }

        // PUT: api/PatternStep/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatternStep(int id, PatternStep patternstep)
        {
            if (id != patternstep.Id)
            {
                return BadRequest();
            }

            _context.Entry(patternstep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatternStepExists(id))
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

        // POST: api/PatternStep
        [HttpPost]
        public async Task<ActionResult<PatternStep>> PostPatternStep(PatternStep patternstep)
        {
            _context.PatternSteps.Add(patternstep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatternStep", new { id = patternstep.Id }, patternstep);
        }

        // DELETE: api/PatternStep/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatternStep(int id)
        {
            var patternstep = await _context.PatternSteps.FindAsync(id);
            if (patternstep == null)
            {
                return NotFound();
            }

            _context.PatternSteps.Remove(patternstep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatternStepExists(int id)
        {
            return _context.PatternSteps.Any(e => e.Id == id);
        }
    }
}
