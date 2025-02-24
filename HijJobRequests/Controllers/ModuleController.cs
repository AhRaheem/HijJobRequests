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
    public class ModuleController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ModuleController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/Module
        [HttpGet]
        public async Task<ActionResult<PaginationList<Module>>> GetModules([FromQuery]PaginationParams paginationParams)
        {
            return await _context.Modules.GetPagedAsync(paginationParams);
        }

        // GET: api/Module/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Module>> GetModule(int id)
        {
            var module = await _context.Modules.FindAsync(id);

            if (module == null)
            {
                return NotFound();
            }

            return module;
        }

        // PUT: api/Module/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule(int id, Module module)
        {
            if (id != module.Id)
            {
                return BadRequest();
            }

            _context.Entry(module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
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

        // POST: api/Module
        [HttpPost]
        public async Task<ActionResult<Module>> PostModule(Module module)
        {
            _context.Modules.Add(module);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModule", new { id = module.Id }, module);
        }

        // DELETE: api/Module/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            var module = await _context.Modules.FindAsync(id);
            if (module == null)
            {
                return NotFound();
            }

            _context.Modules.Remove(module);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModuleExists(int id)
        {
            return _context.Modules.Any(e => e.Id == id);
        }
    }
}
