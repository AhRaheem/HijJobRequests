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
    public class HrEmpCourseController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public HrEmpCourseController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/HrEmpCourse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HrEmpCourse>>> GetHrEmpCourses()
        {
            return await _context.HrEmpCourses.ToListAsync();
        }

        // GET: api/HrEmpCourse/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpCourse>> GetHrEmpCourse(decimal id)
        {
            var hrempcourse = await _context.HrEmpCourses.FindAsync(id);

            if (hrempcourse == null)
            {
                return NotFound();
            }

            return hrempcourse;
        }

        // PUT: api/HrEmpCourse/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpCourse(decimal id, HrEmpCourse hrempcourse)
        {
            if (id != hrempcourse.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempcourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpCourseExists(id))
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

        // POST: api/HrEmpCourse
        [HttpPost]
        public async Task<ActionResult<HrEmpCourse>> PostHrEmpCourse(HrEmpCourse hrempcourse)
        {
            _context.HrEmpCourses.Add(hrempcourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpCourse", new { id = hrempcourse.FCompanyId }, hrempcourse);
        }

        // DELETE: api/HrEmpCourse/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpCourse(decimal id)
        {
            var hrempcourse = await _context.HrEmpCourses.FindAsync(id);
            if (hrempcourse == null)
            {
                return NotFound();
            }

            _context.HrEmpCourses.Remove(hrempcourse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpCourseExists(decimal id)
        {
            return _context.HrEmpCourses.Any(e => e.FCompanyId == id);
        }
    }
}
