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
    public class TdQualiController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdQualiController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdQuali
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdQuali>>> GetTdQualis([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdQualis.GetPagedAsync(paginationParams);
        }

        // GET: api/TdQuali/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdQuali>> GetTdQuali(int id)
        {
            var tdquali = await _context.TdQualis.FindAsync(id);

            if (tdquali == null)
            {
                return NotFound();
            }

            return tdquali;
        }

        // PUT: api/TdQuali/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdQuali(int id, TdQuali tdquali)
        {
            if (id != tdquali.FQualiNo)
            {
                return BadRequest();
            }

            _context.Entry(tdquali).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdQualiExists(id))
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

        // POST: api/TdQuali
        [HttpPost]
        public async Task<ActionResult<TdQuali>> PostTdQuali(TdQuali tdquali)
        {
            _context.TdQualis.Add(tdquali);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdQuali", new { id = tdquali.FQualiNo }, tdquali);
        }

        // DELETE: api/TdQuali/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdQuali(int id)
        {
            var tdquali = await _context.TdQualis.FindAsync(id);
            if (tdquali == null)
            {
                return NotFound();
            }

            _context.TdQualis.Remove(tdquali);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdQualiExists(int id)
        {
            return _context.TdQualis.Any(e => e.FQualiNo == id);
        }
    }
}
