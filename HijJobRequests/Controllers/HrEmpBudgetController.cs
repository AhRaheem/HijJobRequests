using HijJobRequests.Dtos.AppUser;
using HijJobRequests.Models;
using HijJobRequests.Services.AppUser;
using Microsoft.AspNetCore.Authorization;
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
    public class HrEmpBudgetController : ControllerBase
    {
        private readonly DbIthraaContext _context;
        private ICurrentUserService currentUserService;

        public HrEmpBudgetController(DbIthraaContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            this.currentUserService = currentUserService;
        }

        // GET: api/HrEmpBudget
        [HttpGet]
        public async Task<ActionResult<PaginationList<HrEmpBudgetDto>>> GetHrEmpBudgets([FromQuery]PaginationParams paginationParams)
        {
            decimal _companyId =Convert.ToDecimal(currentUserService.GetUserCompany());
            var result = await (from budget in _context.HrEmpBudgets.Where(x => x.FCompanyId == _companyId)
                                join season in _context.TdSeasons
                                    on budget.FSeasonNo equals season.FSeasonNo into seasonJoin
                                from season in seasonJoin.DefaultIfEmpty()

                                join status in _context.TdSeasonStatuses
                                    on budget.FBudgetStatus equals status.FSeasonStatus into statusJoin
                                from status in statusJoin.DefaultIfEmpty()

                                join section in _context.TdSections
                                    on budget.FSectionNo equals section.FSectionNo into sectionJoin
                                from section in sectionJoin.DefaultIfEmpty()

                                join job in _context.TdJobs
                                    on budget.FJobNo equals job.FJobNo into jobJoin
                                from job in jobJoin.DefaultIfEmpty()

                                join manager in _context.HrEmps
                                    on budget.FManagerNo equals manager.FEmpNo into managerJoin
                                from manager in managerJoin.DefaultIfEmpty()

                                join department in _context.Departments
                                    on budget.FDepNo equals department.Id into departmentJoin
                                from department in departmentJoin.DefaultIfEmpty()

                                select new HrEmpBudgetDto
                                {
                                    FBudgetNo = budget.FBudgetNo,
                                    FSeasonName = season != null ? season.FSeasonName : "N/A",
                                    FSectionName = section != null ? section.FSectionName : "N/A",
                                    FJobName = job != null ? job.FJobName : "N/A",
                                    FManagerName = manager != null ? manager.FEmpName : "N/A",
                                    FSalaryAmo = budget.FSalaryAmo,
                                    FSeasonStatus = status != null ? status.FSeasonStatus : 0, // Handle nullable
                                    FSeasonOrderDateFrom = status != null ? status.FSeasonOrderDateFrom : null, // Handle nullable
                                    FSeasonOrderDateTo = status != null ? status.FSeasonOrderDateTo : null, // Handle nullable
                                    FSeasonNo = budget.FSeasonNo,
                                    FSeasonOrderStatus = status != null ? status.FSeasonOrderStatus : 0, // Handle nullable
                                    FBudgetContract = budget.FBudgetContract,
                                    FBudgetPayment = budget.FBudgetPayment,
                                    FDayAco = budget.FDayAco,
                                    FDepNo = budget.FDepNo,
                                    FDepSerNo = budget.FDepSerNo,
                                    FJobAco = budget.FJobAco,
                                    FSalaryDaily = budget.FSalaryDaily,
                                    FSalaryMonthly = budget.FSalaryMonthly
                                })
                                .ToListAsync();
            return Ok(result);
        }

        // GET: api/HrEmpBudget/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HrEmpBudget>> GetHrEmpBudget(decimal id)
        {
            var hrempbudget = await _context.HrEmpBudgets.FindAsync(id);

            if (hrempbudget == null)
            {
                return NotFound();
            }

            return hrempbudget;
        }

        // PUT: api/HrEmpBudget/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHrEmpBudget(decimal id, HrEmpBudget hrempbudget)
        {
            if (id != hrempbudget.FCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(hrempbudget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HrEmpBudgetExists(id))
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

        // POST: api/HrEmpBudget
        [HttpPost]
        public async Task<ActionResult<HrEmpBudget>> PostHrEmpBudget(HrEmpBudget hrempbudget)
        {
            decimal _companyId = 1;
                //Convert.ToDecimal(currentUserService.GetUserCompany());
            hrempbudget.FCompanyId = _companyId;
            string year = DateTime.Now.Year.ToString(); 
            string companyPrefix = _companyId.ToString(); 

            // Find the latest budget number for this year
            var lastBudget = await _context.HrEmpBudgets
                .Where(b => b.FCompanyId == _companyId && b.FBudgetNo.ToString().StartsWith(companyPrefix + year))
                .OrderByDescending(b => b.FBudgetNo)
                .Select(b => b.FBudgetNo)
                .FirstOrDefaultAsync();

            int newSequence = 1; // Default sequence number

            if (lastBudget != 0)
            {
                string lastBudgetStr = lastBudget.ToString();
                string lastSeqStr = lastBudgetStr.Substring(lastBudgetStr.Length - 5);
                newSequence = int.Parse(lastSeqStr) + 1;
            }

            string newBudgetStr = $"{companyPrefix}{year}{newSequence:D5}";
            decimal budgetNo = decimal.Parse(newBudgetStr);
            hrempbudget.FBudgetNo = budgetNo;
            _context.HrEmpBudgets.Add(hrempbudget);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHrEmpBudget", new { id = hrempbudget.FCompanyId }, hrempbudget);
        }

        // DELETE: api/HrEmpBudget/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHrEmpBudget(decimal id)
        {
            var hrempbudget = await _context.HrEmpBudgets.FindAsync(id);
            if (hrempbudget == null)
            {
                return NotFound();
            }

            _context.HrEmpBudgets.Remove(hrempbudget);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HrEmpBudgetExists(decimal id)
        {
            return _context.HrEmpBudgets.Any(e => e.FCompanyId == id);
        }
    }
}
