using Microsoft.AspNetCore.Mvc;
using SinglepageApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPost]
        public IActionResult Validate(string username, string password)
        {
            if (_businessManager.Validate(username, password))
            {
                //redirect to profile information page

                return Ok();
            }
            else
            {
                //redirect to the invalid login page
                return NotFound();
            }
        }

    }
}