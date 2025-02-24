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
    public class ChContractFoodController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public ChContractFoodController(DbIthraaContext context)
        {
            _context = context;
        }

        // GET: api/ChContractFood
        [HttpGet]
        public async Task<ActionResult<PaginationList<ChContractFood>>> GetChContractFoods([FromQuery]PaginationParams paginationParams)
        {
            return await _context.ChContractFoods.GetPagedAsync(paginationParams);
        }

        // GET: api/ChContractFood/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ChContractFood>> GetChContractFood(decimal id)
        {
            var chcontractfood = await _context.ChContractFoods.FindAsync(id);

            if (chcontractfood == null)
            {
                return NotFound();
            }

            return chcontractfood;
        }

        // PUT: api/ChContractFood/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChContractFood(decimal id, ChContractFood chcontractfood)
        {
            if (id != chcontractfood.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(chcontractfood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChContractFoodExists(id))
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

        // POST: api/ChContractFood
        [HttpPost]
        public async Task<ActionResult<ChContractFood>> PostChContractFood(ChContractFood chcontractfood)
        {
            _context.ChContractFoods.Add(chcontractfood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChContractFood", new { id = chcontractfood.FCompanyId }, chcontractfood);
        }

        // DELETE: api/ChContractFood/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChContractFood(decimal id)
        {
            var chcontractfood = await _context.ChContractFoods.FindAsync(id);
            if (chcontractfood == null)
            {
                return NotFound();
            }

            _context.ChContractFoods.Remove(chcontractfood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChContractFoodExists(decimal id)
        {
            return _context.ChContractFoods.Any(e => e.FCompanyId == id);
        }
    }
}
