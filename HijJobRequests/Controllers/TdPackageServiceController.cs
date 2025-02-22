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
    public class TdPackageServiceController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdPackageServiceController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdPackageService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdPackageService>>> GetTdPackageServices()
        {
            return await _context.TdPackageServices.ToListAsync();
        }

        // GET: api/TdPackageService/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdPackageService>> GetTdPackageService(int id)
        {
            var tdpackageservice = await _context.TdPackageServices.FindAsync(id);

            if (tdpackageservice == null)
            {
                return NotFound();
            }

            return tdpackageservice;
        }

        // PUT: api/TdPackageService/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdPackageService(int id, TdPackageService tdpackageservice)
        {
            if (id != tdpackageservice.FServiceNo)
            {
                return BadRequest();
            }

            _context.Entry(tdpackageservice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdPackageServiceExists(id))
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

        // POST: api/TdPackageService
        [HttpPost]
        public async Task<ActionResult<TdPackageService>> PostTdPackageService(TdPackageService tdpackageservice)
        {
            _context.TdPackageServices.Add(tdpackageservice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdPackageService", new { id = tdpackageservice.FServiceNo }, tdpackageservice);
        }

        // DELETE: api/TdPackageService/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdPackageService(int id)
        {
            var tdpackageservice = await _context.TdPackageServices.FindAsync(id);
            if (tdpackageservice == null)
            {
                return NotFound();
            }

            _context.TdPackageServices.Remove(tdpackageservice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdPackageServiceExists(int id)
        {
            return _context.TdPackageServices.Any(e => e.FServiceNo == id);
        }
    }
}
