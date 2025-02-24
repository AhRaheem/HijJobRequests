using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
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
    public class ActionLogController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ActionLogController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ActionLog
        [HttpGet]
        public async Task<ActionResult<PaginationList<ActionLog>>> GetActionLogs([FromQuery]PaginationParams paginationParams)
        {
            return await _context.ActionLogs.GetPagedAsync(paginationParams);
        }

        // GET: api/ActionLog/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ActionLog>> GetActionLog(int id)
        {
            var actionlog = await _context.ActionLogs.FindAsync(id);

            if (actionlog == null)
            {
                return NotFound();
            }

            return actionlog;
        }

        // PUT: api/ActionLog/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActionLog(int id, ActionLog actionlog)
        {
            if (id != actionlog.Id)
            {
                return BadRequest();
            }

            _context.Entry(actionlog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionLogExists(id))
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

        // POST: api/ActionLog
        [HttpPost]
        public async Task<ActionResult<ActionLog>> PostActionLog(ActionLog actionlog)
        {
            _context.ActionLogs.Add(actionlog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActionLog", new { id = actionlog.Id }, actionlog);
        }

        // DELETE: api/ActionLog/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActionLog(int id)
        {
            var actionlog = await _context.ActionLogs.FindAsync(id);
            if (actionlog == null)
            {
                return NotFound();
            }

            _context.ActionLogs.Remove(actionlog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActionLogExists(int id)
        {
            return _context.ActionLogs.Any(e => e.Id == id);
        }
    }
}
