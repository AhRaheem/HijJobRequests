using HijJobRequests.Dtos;
using HijJobRequests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly DbIthraaContext _context;

        public MenuController(DbIthraaContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<MenuDto>>> GetMenu()
        {
            // Retrieve all active main menu items (AppPageMain)
            var mainMenus = await _context.AppPageMains
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
                    .Where(sub => sub.FPageMainNo == main.FPageMainNo)
                    .OrderBy(sub => sub.FPageSubSort)
                    .Select(sub => new SubMenuDto
                    {
                        Id = sub.FPageSubNo,
                        Name = sub.FPageSubName,
                        Order = sub.FPageSubSort,
                        // Load pages
                        Pages = _context.AppPages
                            .Where(p => p.FPageSubNo == sub.FPageSubNo)
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
