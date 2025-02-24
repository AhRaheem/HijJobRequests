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
    public class TdCourseController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdCourseController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdCourse
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdCourse>>> GetTdCourses([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdCourses.GetPagedAsync(paginationParams);
        }

        // GET: api/TdCourse/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdCourse>> GetTdCourse(int id)
        {
            var tdcourse = await _context.TdCourses.FindAsync(id);

            if (tdcourse == null)
            {
                return NotFound();
            }

            return tdcourse;
        }

        // PUT: api/TdCourse/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdCourse(int id, TdCourse tdcourse)
        {
            if (id != tdcourse.FCourseNo)
            {
                return BadRequest();
            }

            _context.Entry(tdcourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdCourseExists(id))
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

        // POST: api/TdCourse
        [HttpPost]
        public async Task<ActionResult<TdCourse>> PostTdCourse(TdCourse tdcourse)
        {
            _context.TdCourses.Add(tdcourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdCourse", new { id = tdcourse.FCourseNo }, tdcourse);
        }

        // DELETE: api/TdCourse/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdCourse(int id)
        {
            var tdcourse = await _context.TdCourses.FindAsync(id);
            if (tdcourse == null)
            {
                return NotFound();
            }

            _context.TdCourses.Remove(tdcourse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdCourseExists(int id)
        {
            return _context.TdCourses.Any(e => e.FCourseNo == id);
        }
    }
}
