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
    public class TdHouseLicenseController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdHouseLicenseController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdHouseLicense
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdHouseLicense>>> GetTdHouseLicenses([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdHouseLicenses.GetPagedAsync(paginationParams);
        }

        // GET: api/TdHouseLicense/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdHouseLicense>> GetTdHouseLicense(int id)
        {
            var tdhouselicense = await _context.TdHouseLicenses.FindAsync(id);

            if (tdhouselicense == null)
            {
                return NotFound();
            }

            return tdhouselicense;
        }

        // PUT: api/TdHouseLicense/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdHouseLicense(int id, TdHouseLicense tdhouselicense)
        {
            if (id != tdhouselicense.FHouseNo)
            {
                return BadRequest();
            }

            _context.Entry(tdhouselicense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdHouseLicenseExists(id))
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

        // POST: api/TdHouseLicense
        [HttpPost]
        public async Task<ActionResult<TdHouseLicense>> PostTdHouseLicense(TdHouseLicense tdhouselicense)
        {
            _context.TdHouseLicenses.Add(tdhouselicense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdHouseLicense", new { id = tdhouselicense.FHouseNo }, tdhouselicense);
        }

        // DELETE: api/TdHouseLicense/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdHouseLicense(int id)
        {
            var tdhouselicense = await _context.TdHouseLicenses.FindAsync(id);
            if (tdhouselicense == null)
            {
                return NotFound();
            }

            _context.TdHouseLicenses.Remove(tdhouselicense);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdHouseLicenseExists(int id)
        {
            return _context.TdHouseLicenses.Any(e => e.FHouseNo == id);
        }
    }
}
