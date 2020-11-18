using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_AuthorizeAttribute.Models;
using JWT_AuthorizeAttribute.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_AuthorizeAttribute.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User userModel)
        {
            
            var user = _authenticateService.Authenticate(userModel.UserName, userModel.Password);

            if (user == null)
                return BadRequest(new { message = "User or password is incorrect" });

            return Ok(user);
        }
    }
}
