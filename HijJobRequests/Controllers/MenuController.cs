using HijJobRequests.Dtos;
using HijJobRequests.Models;
using HijJobRequests.Services.AppUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class MenuController : ControllerBase
    {
        private readonly DbIthraaContext _context;
        private readonly ICurrentUserService _currentUserService;
        public MenuController(DbIthraaContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<MenuDto>>> GetMenu()
        {
            decimal _compnayId = Convert.ToDecimal(_currentUserService.GetUserCompany());
            var mainMenus = await _context.AppPageMains.Where(x=>x.FCompanyId==_compnayId)
                .OrderBy(m => m.FPageMainSort)
                .ToListAsync();

            // Build the menu hierarchy
            var menuDtos = mainMenus.Select(main => new MenuDto
            {
                Id = main.FPageMainNo,
                Name = main.FPageMainName,
                Order = main.FPageMainSort,
                // Load submenus
                SubMenus = _context.AppPageSubs
                    .Where(sub => sub.FPageMainNo == main.FPageMainNo && main.FCompanyId== _compnayId)
                    .OrderBy(sub => sub.FPageSubSort)
                    .Select(sub => new SubMenuDto
                    {
                        Id = sub.FPageSubNo,
                        Name = sub.FPageSubName,
                        Order = sub.FPageSubSort,
                        // Load pages
                        Pages = _context.AppPages
                            .Where(p => p.FPageSubNo == sub.FPageSubNo && p.FCompanyId == _compnayId)
                            .OrderBy(p => p.FPageSort)
                            .Select(p => new PageDto
                            {
                                Id = p.FPageNo,
                                Name = p.FPageName,
                                Order = p.FPageSort,
                                Link = p.FLinkNo
                            })
                            .ToList()
                    })
                    .ToList()
            }).ToList();

            return Ok(menuDtos);
        }
    }
}
