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
    public class ActionTypeController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ActionTypeController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ActionType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActionType>>> GetActionTypes()
        {
            return await _context.ActionTypes.ToListAsync();
        }

        // GET: api/ActionType/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ActionType>> GetActionType(int id)
        {
            var actiontype = await _context.ActionTypes.FindAsync(id);

            if (actiontype == null)
            {
                return NotFound();
            }

            return actiontype;
        }

        // PUT: api/ActionType/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActionType(int id, ActionType actiontype)
        {
            if (id != actiontype.Id)
            {
                return BadRequest();
            }

            _context.Entry(actiontype).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionTypeExists(id))
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

        // POST: api/ActionType
        [HttpPost]
        public async Task<ActionResult<ActionType>> PostActionType(ActionType actiontype)
        {
            _context.ActionTypes.Add(actiontype);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActionType", new { id = actiontype.Id }, actiontype);
        }

        // DELETE: api/ActionType/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActionType(int id)
        {
            var actiontype = await _context.ActionTypes.FindAsync(id);
            if (actiontype == null)
            {
                return NotFound();
            }

            _context.ActionTypes.Remove(actiontype);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActionTypeExists(int id)
        {
            return _context.ActionTypes.Any(e => e.Id == id);
        }
    }
}
