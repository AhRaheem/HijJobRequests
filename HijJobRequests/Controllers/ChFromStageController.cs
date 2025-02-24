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
    public class ChFromStageController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChFromStageController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChFromStage
        [HttpGet]
        public async Task<ActionResult<PaginationList<ChFromStage>>> GetChFromStages([FromQuery]PaginationParams paginationParams)
        {
            return await _context.ChFromStages.GetPagedAsync(paginationParams);
        }

        // GET: api/ChFromStage/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChFromStage>> GetChFromStage(decimal id)
        {
            var chfromstage = await _context.ChFromStages.FindAsync(id);

            if (chfromstage == null)
            {
                return NotFound();
            }

            return chfromstage;
        }

        // PUT: api/ChFromStage/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChFromStage(decimal id, ChFromStage chfromstage)
        {
            if (id != chfromstage.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chfromstage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChFromStageExists(id))
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

        // POST: api/ChFromStage
        [HttpPost]
        public async Task<ActionResult<ChFromStage>> PostChFromStage(ChFromStage chfromstage)
        {
            _context.ChFromStages.Add(chfromstage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChFromStage", new { id = chfromstage.FCompanyId }, chfromstage);
        }

        // DELETE: api/ChFromStage/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChFromStage(decimal id)
        {
            var chfromstage = await _context.ChFromStages.FindAsync(id);
            if (chfromstage == null)
            {
                return NotFound();
            }

            _context.ChFromStages.Remove(chfromstage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChFromStageExists(decimal id)
        {
            return _context.ChFromStages.Any(e => e.FCompanyId == id);
        }
    }
}
