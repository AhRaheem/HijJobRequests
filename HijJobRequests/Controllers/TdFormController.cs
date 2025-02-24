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
    public class TdFormController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdFormController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdForm
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdForm>>> GetTdForms([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdForms.GetPagedAsync(paginationParams);
        }

        // GET: api/TdForm/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdForm>> GetTdForm(decimal id)
        {
            var tdform = await _context.TdForms.FindAsync(id);

            if (tdform == null)
            {
                return NotFound();
            }

            return tdform;
        }

        // PUT: api/TdForm/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdForm(decimal id, TdForm tdform)
        {
            if (id != tdform.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdform).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdFormExists(id))
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

        // POST: api/TdForm
        [HttpPost]
        public async Task<ActionResult<TdForm>> PostTdForm(TdForm tdform)
        {
            _context.TdForms.Add(tdform);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdForm", new { id = tdform.FCompanyId }, tdform);
        }

        // DELETE: api/TdForm/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdForm(decimal id)
        {
            var tdform = await _context.TdForms.FindAsync(id);
            if (tdform == null)
            {
                return NotFound();
            }

            _context.TdForms.Remove(tdform);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdFormExists(decimal id)
        {
            return _context.TdForms.Any(e => e.FCompanyId == id);
        }
    }
}
