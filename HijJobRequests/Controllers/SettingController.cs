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
    public class SettingController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public SettingController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/Setting
        [HttpGet]
        public async Task<ActionResult<PaginationList<Setting>>> GetSettings([FromQuery]PaginationParams paginationParams)
        {
            return await _context.Settings.GetPagedAsync(paginationParams);
        }

        // GET: api/Setting/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Setting>> GetSetting(string id)
        {
            var setting = await _context.Settings.FindAsync(id);

            if (setting == null)
            {
                return NotFound();
            }

            return setting;
        }

        // PUT: api/Setting/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSetting(string id, Setting setting)
        {
            if (id != setting.Id)
            {
                return BadRequest();
            }

            _context.Entry(setting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettingExists(id))
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

        // POST: api/Setting
        [HttpPost]
        public async Task<ActionResult<Setting>> PostSetting(Setting setting)
        {
            _context.Settings.Add(setting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSetting", new { id = setting.Id }, setting);
        }

        // DELETE: api/Setting/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSetting(string id)
        {
            var setting = await _context.Settings.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }

            _context.Settings.Remove(setting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SettingExists(string id)
        {
            return _context.Settings.Any(e => e.Id == id);
        }
    }
}
