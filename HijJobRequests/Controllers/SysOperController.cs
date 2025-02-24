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
    public class SysOperController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SysOperController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/SysOper
        [HttpGet]
        public async Task<ActionResult<PaginationList<SysOper>>> GetSysOpers([FromQuery]PaginationParams paginationParams)
        {
            return await _context.SysOpers.GetPagedAsync(paginationParams);
        }

        // GET: api/SysOper/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SysOper>> GetSysOper(int id)
        {
            var sysoper = await _context.SysOpers.FindAsync(id);

            if (sysoper == null)
            {
                return NotFound();
            }

            return sysoper;
        }

        // PUT: api/SysOper/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysOper(int id, SysOper sysoper)
        {
            if (id != sysoper.FOperNo)
            {
                return BadRequest();
            }

            _context.Entry(sysoper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysOperExists(id))
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

        // POST: api/SysOper
        [HttpPost]
        public async Task<ActionResult<SysOper>> PostSysOper(SysOper sysoper)
        {
            _context.SysOpers.Add(sysoper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysOper", new { id = sysoper.FOperNo }, sysoper);
        }

        // DELETE: api/SysOper/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysOper(int id)
        {
            var sysoper = await _context.SysOpers.FindAsync(id);
            if (sysoper == null)
            {
                return NotFound();
            }

            _context.SysOpers.Remove(sysoper);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysOperExists(int id)
        {
            return _context.SysOpers.Any(e => e.FOperNo == id);
        }
    }
}
