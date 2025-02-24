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
    public class PatternStepActionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public PatternStepActionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/PatternStepAction
        [HttpGet]
        public async Task<ActionResult<PaginationList<PatternStepAction>>> GetPatternStepActions([FromQuery]PaginationParams paginationParams)
        {
            return await _context.PatternStepActions.GetPagedAsync(paginationParams);
        }

        // GET: api/PatternStepAction/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<PatternStepAction>> GetPatternStepAction(int id)
        {
            var patternstepaction = await _context.PatternStepActions.FindAsync(id);

            if (patternstepaction == null)
            {
                return NotFound();
            }

            return patternstepaction;
        }

        // PUT: api/PatternStepAction/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatternStepAction(int id, PatternStepAction patternstepaction)
        {
            if (id != patternstepaction.Id)
            {
                return BadRequest();
            }

            _context.Entry(patternstepaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatternStepActionExists(id))
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

        // POST: api/PatternStepAction
        [HttpPost]
        public async Task<ActionResult<PatternStepAction>> PostPatternStepAction(PatternStepAction patternstepaction)
        {
            _context.PatternStepActions.Add(patternstepaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatternStepAction", new { id = patternstepaction.Id }, patternstepaction);
        }

        // DELETE: api/PatternStepAction/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatternStepAction(int id)
        {
            var patternstepaction = await _context.PatternStepActions.FindAsync(id);
            if (patternstepaction == null)
            {
                return NotFound();
            }

            _context.PatternStepActions.Remove(patternstepaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatternStepActionExists(int id)
        {
            return _context.PatternStepActions.Any(e => e.Id == id);
        }
    }
}
