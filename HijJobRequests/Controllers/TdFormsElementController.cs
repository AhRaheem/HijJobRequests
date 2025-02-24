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
    public class TdFormsElementController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdFormsElementController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdFormsElement
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdFormsElement>>> GetTdFormsElements([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdFormsElements.GetPagedAsync(paginationParams);
        }

        // GET: api/TdFormsElement/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdFormsElement>> GetTdFormsElement(decimal id)
        {
            var tdformselement = await _context.TdFormsElements.FindAsync(id);

            if (tdformselement == null)
            {
                return NotFound();
            }

            return tdformselement;
        }

        // PUT: api/TdFormsElement/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdFormsElement(decimal id, TdFormsElement tdformselement)
        {
            if (id != tdformselement.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tdformselement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdFormsElementExists(id))
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

        // POST: api/TdFormsElement
        [HttpPost]
        public async Task<ActionResult<TdFormsElement>> PostTdFormsElement(TdFormsElement tdformselement)
        {
            _context.TdFormsElements.Add(tdformselement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdFormsElement", new { id = tdformselement.FCompanyId }, tdformselement);
        }

        // DELETE: api/TdFormsElement/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdFormsElement(decimal id)
        {
            var tdformselement = await _context.TdFormsElements.FindAsync(id);
            if (tdformselement == null)
            {
                return NotFound();
            }

            _context.TdFormsElements.Remove(tdformselement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdFormsElementExists(decimal id)
        {
            return _context.TdFormsElements.Any(e => e.FCompanyId == id);
        }
    }
}
