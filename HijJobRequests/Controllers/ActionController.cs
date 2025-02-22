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
    public class ActionController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ActionController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/Action
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HijJobRequests.Models.Action>>> GetActions()
        {
            return await _context.Actions.ToListAsync();
        }

        // GET: api/Action/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HijJobRequests.Models.Action>> GetAction(decimal id)
        {
            var action = await _context.Actions.FindAsync(id);

            if (action == null)
            {
                return NotFound();
            }

            return action;
        }

        // PUT: api/Action/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAction(decimal id, HijJobRequests.Models.Action action)
        {
            if (id != action.Id)
            {
                return BadRequest();
            }

            _context.Entry(action).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionExists(id))
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

        // POST: api/Action
        [HttpPost]
        public async Task<ActionResult<HijJobRequests.Models.Action>> PostAction(HijJobRequests.Models.Action action)
        {
            _context.Actions.Add(action);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAction", new { id = action.Id }, action);
        }

        // DELETE: api/Action/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAction(decimal id)
        {
            var action = await _context.Actions.FindAsync(id);
            if (action == null)
            {
                return NotFound();
            }

            _context.Actions.Remove(action);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActionExists(decimal id)
        {
            return _context.Actions.Any(e => e.Id == id);
        }
    }
}
