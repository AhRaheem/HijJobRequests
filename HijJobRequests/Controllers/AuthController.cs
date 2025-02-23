using System.Data.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HijJobRequests.Dtos;
using HijJobRequests.Models;
using HijJobRequests.Vars;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HijJobRequests.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly DbIthraaContext _context;
        readonly IConfiguration _configuration;

        public AuthController(DbIthraaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> VerifyLogin(LoginDto model)
        {
            return Ok((await _context.AppUsers.FirstOrDefaultAsync(x => x.FEmail.Equals(model.Identityfier) || x.FJawNo.Equals(model.Identityfier) || x.FIdNo.Equals(model.Identityfier) && x.FUserPass.Equals(model.Password))) is not null ? SetAppUserOtp(model.Identityfier) : string.Empty);
        }

        [HttpPost("VerifyOtp")]
        public async Task<ActionResult<string>> VerifyOtp(LoginDto model)
        {
            SharedVars.AppUsersOtps.RemoveWhere(x => x.Item3 < DateTime.UtcNow);
            return Ok(SharedVars.AppUsersOtps.Any(x => x.Item1.Equals(model.Identityfier) && x.Item2.Equals(model.Otp)) ? await GenerateToken(model.Identityfier, model.Company) : string.Empty);
        }

        // [HttpGet("GetMenuItems/{UserId}")]
        // public async Task<ActionResult<IEnumerable<AppUserMenuItems>>> GetMenuItems(int UserId)
        // {
        //     return Ok(await _context.AppUserMenuItems.Where(x => x.FUserId == UserId).ToListAsync());
        // }

        private string SetAppUserOtp(string Identityfier)
        {
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var Otp = string.Join("", Enumerable.Range(0, 4)
                .Select(_ => digits[new Random().Next(digits.Length)]));
            SharedVars.AppUsersOtps.Add((Identityfier, Otp, DateTime.UtcNow.AddMinutes(1)));
            return Otp;
        }

        private async Task<string> GenerateToken(string Identityfier, string Company)
        {
            var AppUsr = await _context.AppUsers.SingleOrDefaultAsync(x => x.FEmail.Equals(Identityfier) || x.FJawNo.Equals(Identityfier) || x.FIdNo.Equals(Identityfier));
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, AppUsr.FUserId.ToString()),
            new Claim(JwtRegisteredClaimNames.Name, AppUsr.FUserName),
            new Claim(JwtRegisteredClaimNames.Email, AppUsr.FEmail),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("Company", Company),
            new Claim("Phone", AppUsr.FJawNo.ToString()),
            new Claim("Identity", AppUsr.FIdNo.ToString())
        };

            var Permisions = await _context.AppUserPermissions.Where(x => x.FUserId == AppUsr.FUserId).ToListAsync();
            foreach (var role in Permisions)
            {
                claims.Add(new Claim(type: ClaimTypes.Role, value: role.FPermNo.ToString()));
            }

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(int.Parse(jwtSettings["ExpiryMinutes"])),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
