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
    public class SysRegisterController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SysRegisterController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/SysRegister
        [HttpGet]
        public async Task<ActionResult<PaginationList<SysRegister>>> GetSysRegisters([FromQuery]PaginationParams paginationParams)
        {
            return await _context.SysRegisters.GetPagedAsync(paginationParams);
        }

        // GET: api/SysRegister/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SysRegister>> GetSysRegister(decimal id)
        {
            var sysregister = await _context.SysRegisters.FindAsync(id);

            if (sysregister == null)
            {
                return NotFound();
            }

            return sysregister;
        }

        // PUT: api/SysRegister/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysRegister(decimal id, SysRegister sysregister)
        {
            if (id != sysregister.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(sysregister).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysRegisterExists(id))
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

        // POST: api/SysRegister
        [HttpPost]
        public async Task<ActionResult<SysRegister>> PostSysRegister(SysRegister sysregister)
        {
            _context.SysRegisters.Add(sysregister);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSysRegister", new { id = sysregister.FCompanyId }, sysregister);
        }

        // DELETE: api/SysRegister/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysRegister(decimal id)
        {
            var sysregister = await _context.SysRegisters.FindAsync(id);
            if (sysregister == null)
            {
                return NotFound();
            }

            _context.SysRegisters.Remove(sysregister);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SysRegisterExists(decimal id)
        {
            return _context.SysRegisters.Any(e => e.FCompanyId == id);
        }
    }
}
