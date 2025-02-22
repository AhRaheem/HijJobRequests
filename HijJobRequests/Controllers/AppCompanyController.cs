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
    public class AppCompanyController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public AppCompanyController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/AppCompany
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppCompany>>> GetAppCompanys()
        {
            return await _context.AppCompanies.ToListAsync();
        }

        // GET: api/AppCompany/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppCompany>> GetAppCompany(decimal id)
        {
            var appcompany = await _context.AppCompanies.FindAsync(id);

            if (appcompany == null)
            {
                return NotFound();
            }

            return appcompany;
        }

        // PUT: api/AppCompany/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppCompany(decimal id, AppCompany appcompany)
        {
            if (id != appcompany.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(appcompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppCompanyExists(id))
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

        // POST: api/AppCompany
        [HttpPost]
        public async Task<ActionResult<AppCompany>> PostAppCompany(AppCompany appcompany)
        {
            _context.AppCompanies.Add(appcompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppCompany", new { id = appcompany.FCompanyId }, appcompany);
        }

        // DELETE: api/AppCompany/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppCompany(decimal id)
        {
            var appcompany = await _context.AppCompanies.FindAsync(id);
            if (appcompany == null)
            {
                return NotFound();
            }

            _context.AppCompanies.Remove(appcompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppCompanyExists(decimal id)
        {
            return _context.AppCompanies.Any(e => e.FCompanyId == id);
        }
    }
}
