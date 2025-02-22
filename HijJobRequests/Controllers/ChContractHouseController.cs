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
    public class ChContractHouseController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChContractHouseController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChContractHouse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChContractHouse>>> GetChContractHouses()
        {
            return await _context.ChContractHouses.ToListAsync();
        }

        // GET: api/ChContractHouse/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChContractHouse>> GetChContractHouse(decimal id)
        {
            var chcontracthouse = await _context.ChContractHouses.FindAsync(id);

            if (chcontracthouse == null)
            {
                return NotFound();
            }

            return chcontracthouse;
        }

        // PUT: api/ChContractHouse/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChContractHouse(decimal id, ChContractHouse chcontracthouse)
        {
            if (id != chcontracthouse.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chcontracthouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChContractHouseExists(id))
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

        // POST: api/ChContractHouse
        [HttpPost]
        public async Task<ActionResult<ChContractHouse>> PostChContractHouse(ChContractHouse chcontracthouse)
        {
            _context.ChContractHouses.Add(chcontracthouse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChContractHouse", new { id = chcontracthouse.FCompanyId }, chcontracthouse);
        }

        // DELETE: api/ChContractHouse/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChContractHouse(decimal id)
        {
            var chcontracthouse = await _context.ChContractHouses.FindAsync(id);
            if (chcontracthouse == null)
            {
                return NotFound();
            }

            _context.ChContractHouses.Remove(chcontracthouse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChContractHouseExists(decimal id)
        {
            return _context.ChContractHouses.Any(e => e.FCompanyId == id);
        }
    }
}
