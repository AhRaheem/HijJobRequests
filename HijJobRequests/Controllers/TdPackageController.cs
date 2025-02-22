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
    public class TdPackageController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdPackageController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdPackage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TdPackage>>> GetTdPackages()
        {
            return await _context.TdPackages.ToListAsync();
        }

        // GET: api/TdPackage/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdPackage>> GetTdPackage(int id)
        {
            var tdpackage = await _context.TdPackages.FindAsync(id);

            if (tdpackage == null)
            {
                return NotFound();
            }

            return tdpackage;
        }

        // PUT: api/TdPackage/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdPackage(int id, TdPackage tdpackage)
        {
            if (id != tdpackage.FPackageNo)
            {
                return BadRequest();
            }

            _context.Entry(tdpackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdPackageExists(id))
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

        // POST: api/TdPackage
        [HttpPost]
        public async Task<ActionResult<TdPackage>> PostTdPackage(TdPackage tdpackage)
        {
            _context.TdPackages.Add(tdpackage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdPackage", new { id = tdpackage.FPackageNo }, tdpackage);
        }

        // DELETE: api/TdPackage/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdPackage(int id)
        {
            var tdpackage = await _context.TdPackages.FindAsync(id);
            if (tdpackage == null)
            {
                return NotFound();
            }

            _context.TdPackages.Remove(tdpackage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdPackageExists(int id)
        {
            return _context.TdPackages.Any(e => e.FPackageNo == id);
        }
    }
}
