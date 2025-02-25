using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HijJobRequests.Dtos.Common;
using HijJobRequests.Extenition;
using Microsoft.AspNetCore.Authorization;
using HijJobRequests.Dtos.AppUser;
using HijJobRequests.Services.AppUser;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class HrEmpOrderCareController : ControllerBase
    {
        private readonly DbIthraaContext _context;
        private readonly ICurrentUserService currentUserService;
        public HrEmpOrderCareController(DbIthraaContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            this.currentUserService = currentUserService;
        }

        // GET: api/HrEmpOrderCare
        [HttpGet]
        public async Task<ActionResult<PaginationList<HrEmpOrderCareDto>>> GetHrEmpOrderCares([FromQuery]PaginationParams paginationParams)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());
            var query = from care in _context.HrEmpOrderCares.Where(x=>x.FCompanyId== _companyId)
                        join season in _context.TdSeasons on care.FSeasonNo equals season.FSeasonNo into seasonGroup
                        from season in seasonGroup.DefaultIfEmpty() // Left join
                        join section in _context.TdSections on care.FSectionNo equals section.FSectionNo into sectionGroup
                        from section in sectionGroup.DefaultIfEmpty() // Left join
                        select new HrEmpOrderCareDto
                        {
                            FLastUpdate = care.FLastUpdate,
                            FLastUpdateUser = care.FLastUpdateUser,
                            FLastUpdateSum = care.FLastUpdateSum,
                            FLastUpdateOper = care.FLastUpdateOper,
                            FLastUpdateOperNo = care.FLastUpdateOperNo,
                            FOrderNo = care.FOrderNo,
                            FSerNo = care.FSerNo,
                            FSeasonName = season != null ? season.FSeasonName : "", // Handle null case
                            FSectionName = section != null ? section.FSectionName : "", // Handle null case
                            FCareType = care.FCareType,
                            FCareNo = care.FCareNo,
                            FCareDate = care.FCareDate,
                            FCareTime = care.FCareTime,
                            FCareNote = care.FCareNote,
                            FReturnDate = care.FReturnDate,
                            FReturnTime = care.FReturnTime,
                            FReturnNote = care.FReturnNote,
                            FCareStatus = care.FCareStatus
                        };

            return await query.GetPagedAsync(paginationParams);
        }

        // GET: api/HrEmpOrderCare/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpOrderCare>> GetHrEmpOrderCare(decimal id)
        {
            var hrempordercare = await _context.HrEmpOrderCares.FindAsync(id);

            if (hrempordercare == null)
            {
                return NotFound();
            }

            return hrempordercare;
        }

        // PUT: api/HrEmpOrderCare/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpOrderCare(decimal id, HrEmpOrderCare hrempordercare)
        {
            if (id != hrempordercare.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempordercare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpOrderCareExists(id))
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

        // POST: api/HrEmpOrderCare
        [HttpPost]
        public async Task<ActionResult<HrEmpOrderCare>> PostHrEmpOrderCare(HrEmpOrderCare hrempordercare)
        {
            decimal _companyId = Convert.ToDecimal(currentUserService.GetUserCompany());

            var newFSerNo = await _context.HrEmpBudgets
                .Where(x => x.FCompanyId == _companyId)
                .CountAsync() + 1;
            hrempordercare.FSerNo = newFSerNo;
            hrempordercare.FCompanyId = _companyId;
            _context.HrEmpOrderCares.Add(hrempordercare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpOrderCare", new { id = hrempordercare.FCompanyId }, hrempordercare);
        }

        // DELETE: api/HrEmpOrderCare/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpOrderCare(decimal id)
        {
            var hrempordercare = await _context.HrEmpOrderCares.FindAsync(id);
            if (hrempordercare == null)
            {
                return NotFound();
            }

            _context.HrEmpOrderCares.Remove(hrempordercare);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpOrderCareExists(decimal id)
        {
            return _context.HrEmpOrderCares.Any(e => e.FCompanyId == id);
        }
    }
}
