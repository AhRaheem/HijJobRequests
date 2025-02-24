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
    public class TdCityController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public TdCityController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/TdCity
        [HttpGet]
        public async Task<ActionResult<PaginationList<TdCity>>> GetTdCitys([FromQuery]PaginationParams paginationParams)
        {
            return await _context.TdCities.GetPagedAsync(paginationParams);
        }

        // GET: api/TdCity/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TdCity>> GetTdCity(int id)
        {
            var tdcity = await _context.TdCities.FindAsync(id);

            if (tdcity == null)
            {
                return NotFound();
            }

            return tdcity;
        }

        // PUT: api/TdCity/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTdCity(int id, TdCity tdcity)
        {
            if (id != tdcity.FCityNo)
            {
                return BadRequest();
            }

            _context.Entry(tdcity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdCityExists(id))
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

        // POST: api/TdCity
        [HttpPost]
        public async Task<ActionResult<TdCity>> PostTdCity(TdCity tdcity)
        {
            _context.TdCities.Add(tdcity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTdCity", new { id = tdcity.FCityNo }, tdcity);
        }

        // DELETE: api/TdCity/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTdCity(int id)
        {
            var tdcity = await _context.TdCities.FindAsync(id);
            if (tdcity == null)
            {
                return NotFound();
            }

            _context.TdCities.Remove(tdcity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TdCityExists(int id)
        {
            return _context.TdCities.Any(e => e.FCityNo == id);
        }
    }
}
