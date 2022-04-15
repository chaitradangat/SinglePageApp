using Microsoft.AspNetCore.Mvc;
using SinglepageApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SinglePageApp.Domain.Dto;

namespace SinglePageApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {

        IBusinessManager _businessManager;

        public LoginController(IBusinessManager businessManager)
        {
            _businessManager = businessManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return StatusCode(200);
        }

        [HttpPost(("validate"))]
        public IActionResult Validate(LoginDto login)
        {
            if (_businessManager.Validate(login.UserName, login.Password))
            {
                //redirect to profile information page
                return StatusCode(200, "Login Successful");
            }
            else
            {
                //redirect to the invalid login page
                return NotFound();
            }
        }

    }
}