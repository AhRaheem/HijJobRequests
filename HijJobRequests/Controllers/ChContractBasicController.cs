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
    public class ChContractBasicController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChContractBasicController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChContractBasic
        [HttpGet]
        public async Task<ActionResult<PaginationList<ChContractBasic>>> GetChContractBasics([FromQuery]PaginationParams paginationParams)
        {
            return await _context.ChContractBasics.GetPagedAsync(paginationParams);
        }

        // GET: api/ChContractBasic/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChContractBasic>> GetChContractBasic(decimal id)
        {
            var chcontractbasic = await _context.ChContractBasics.FindAsync(id);

            if (chcontractbasic == null)
            {
                return NotFound();
            }

            return chcontractbasic;
        }

        // PUT: api/ChContractBasic/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChContractBasic(decimal id, ChContractBasic chcontractbasic)
        {
            if (id != chcontractbasic.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chcontractbasic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChContractBasicExists(id))
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

        // POST: api/ChContractBasic
        [HttpPost]
        public async Task<ActionResult<ChContractBasic>> PostChContractBasic(ChContractBasic chcontractbasic)
        {
            _context.ChContractBasics.Add(chcontractbasic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChContractBasic", new { id = chcontractbasic.FCompanyId }, chcontractbasic);
        }

        // DELETE: api/ChContractBasic/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChContractBasic(decimal id)
        {
            var chcontractbasic = await _context.ChContractBasics.FindAsync(id);
            if (chcontractbasic == null)
            {
                return NotFound();
            }

            _context.ChContractBasics.Remove(chcontractbasic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChContractBasicExists(decimal id)
        {
            return _context.ChContractBasics.Any(e => e.FCompanyId == id);
        }
    }
}
