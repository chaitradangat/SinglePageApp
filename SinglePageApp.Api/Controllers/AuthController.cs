using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SinglePageApp.Domain;
using SinglePageApp.Domain.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {

        public AuthController()
        {

        }

        /// <summary>
        /// Generates token after successful login 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            if (login == null)
            {
                return BadRequest();
            }

            if (login.UserName == "test" && login.Password == "test")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("key123abcdefghij"));

                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.UserName),
                    new Claim(ClaimTypes.Role, "Operator")
                };

                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44315",
                    audience: "http://localhost:44315",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
