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
    public class HrEmpController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmp
        [HttpGet]
        public async Task<ActionResult<PaginationList<HrEmp>>> GetHrEmps([FromQuery]PaginationParams paginationParams)
        {
            return await _context.HrEmps.GetPagedAsync(paginationParams);
        }

        // GET: api/HrEmp/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmp>> GetHrEmp(decimal id)
        {
            var hremp = await _context.HrEmps.FindAsync(id);

            if (hremp == null)
            {
                return NotFound();
            }

            return hremp;
        }

        // PUT: api/HrEmp/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmp(decimal id, HrEmp hremp)
        {
            if (id != hremp.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hremp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpExists(id))
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

        // POST: api/HrEmp
        [HttpPost]
        public async Task<ActionResult<HrEmp>> PostHrEmp(HrEmp hremp)
        {
            _context.HrEmps.Add(hremp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmp", new { id = hremp.FCompanyId }, hremp);
        }

        // DELETE: api/HrEmp/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmp(decimal id)
        {
            var hremp = await _context.HrEmps.FindAsync(id);
            if (hremp == null)
            {
                return NotFound();
            }

            _context.HrEmps.Remove(hremp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpExists(decimal id)
        {
            return _context.HrEmps.Any(e => e.FCompanyId == id);
        }
    }
}
