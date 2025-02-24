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
    public class ChContractCampController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChContractCampController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChContractCamp
        [HttpGet]
        public async Task<ActionResult<PaginationList<ChContractCamp>>> GetChContractCamps([FromQuery]PaginationParams paginationParams)
        {
            return await _context.ChContractCamps.GetPagedAsync(paginationParams);
        }

        // GET: api/ChContractCamp/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChContractCamp>> GetChContractCamp(decimal id)
        {
            var chcontractcamp = await _context.ChContractCamps.FindAsync(id);

            if (chcontractcamp == null)
            {
                return NotFound();
            }

            return chcontractcamp;
        }

        // PUT: api/ChContractCamp/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChContractCamp(decimal id, ChContractCamp chcontractcamp)
        {
            if (id != chcontractcamp.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chcontractcamp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChContractCampExists(id))
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

        // POST: api/ChContractCamp
        [HttpPost]
        public async Task<ActionResult<ChContractCamp>> PostChContractCamp(ChContractCamp chcontractcamp)
        {
            _context.ChContractCamps.Add(chcontractcamp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChContractCamp", new { id = chcontractcamp.FCompanyId }, chcontractcamp);
        }

        // DELETE: api/ChContractCamp/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChContractCamp(decimal id)
        {
            var chcontractcamp = await _context.ChContractCamps.FindAsync(id);
            if (chcontractcamp == null)
            {
                return NotFound();
            }

            _context.ChContractCamps.Remove(chcontractcamp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChContractCampExists(decimal id)
        {
            return _context.ChContractCamps.Any(e => e.FCompanyId == id);
        }
    }
}
