using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
using Microsoft.AspNetCore.Authorization;
using HijJobRequests.Services.AppUser;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController,Authorize]
    public class HrEmpOrderController : ControllerBase
    {
        private readonly DbIthraaContext _context;
        private readonly ICurrentUserService currentUserService;
        public HrEmpOrderController(DbIthraaContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            this.currentUserService = currentUserService;
        }

        // GET: api/HrEmpOrder
        [HttpGet("GetAllHrEmpOrders")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetAllHrEmpOrders([FromQuery]PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x=>x.FOrderStatus==1 && x.FCompanyId== _companyId).GetPagedAsync(paginationParams);
        }

        [HttpGet("GetHrEmpOrdersTarshih")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetHrEmpOrdersTarshih([FromQuery] PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x => x.FOrderStatus == 3 && x.FCompanyId == _companyId).GetPagedAsync(paginationParams);
        }

        [HttpGet("GetHrEmpOrdersApprovedTarshih")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetHrEmpOrdersApprovedTarshih([FromQuery] PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x => x.FOrderStatus == 4 && x.FCompanyId == _companyId).GetPagedAsync(paginationParams);
        }

        [HttpGet("GetHrEmpOrdersWorkOffer")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetHrEmpOrdersWorkOffer([FromQuery] PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x => x.FOrderStatus == 5 && x.FCompanyId == _companyId).GetPagedAsync(paginationParams);
        }

        [HttpGet("GetHrEmpOrdersWorkContract")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetHrEmpOrdersWorkContract([FromQuery] PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x => x.FOrderStatus == 6 && x.FCompanyId == _companyId).GetPagedAsync(paginationParams);
        }

        [HttpGet("GetHrEmpOrdersApproveContract")]
        public async Task<ActionResult<PaginationList<HrEmpOrder>>> GetHrEmpOrdersApproveContract([FromQuery] PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            return await _context.HrEmpOrders.Where(x => x.FOrderStatus == 7 && x.FCompanyId == _companyId).GetPagedAsync(paginationParams);
        }

        // GET: api/HrEmpOrder/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpOrder>> GetHrEmpOrder(decimal id)
        {
            var hremporder = await _context.HrEmpOrders.FindAsync(id);

            if (hremporder == null)
            {
                return NotFound();
            }

            return hremporder;
        }

        // PUT: api/HrEmpOrder/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpOrder(decimal id, HrEmpOrder hremporder)
        {
            if (id != hremporder.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hremporder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpOrderExists(id))
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

        // POST: api/HrEmpOrder
        [HttpPost]
        public async Task<ActionResult<HrEmpOrder>> PostHrEmpOrder(HrEmpOrder hremporder)
        {
            _context.HrEmpOrders.Add(hremporder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpOrder", new { id = hremporder.FCompanyId }, hremporder);
        }

        // DELETE: api/HrEmpOrder/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpOrder(decimal id)
        {
            var hremporder = await _context.HrEmpOrders.FindAsync(id);
            if (hremporder == null)
            {
                return NotFound();
            }

            _context.HrEmpOrders.Remove(hremporder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpOrderExists(decimal id)
        {
            return _context.HrEmpOrders.Any(e => e.FCompanyId == id);
        }
    }
}
