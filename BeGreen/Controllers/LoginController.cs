using AutoMapper;
using BeGreen.Application;
using BeGreen.Context;
using BeGreen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginApplication _loginApplication;

        private readonly IMapper _mapper;

        public LoginController(IMapper mapper, LoginApplication loginApplication)
        {
            _mapper = mapper;
            _loginApplication = loginApplication;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Login(string email, string senha)
        {
            //var user = _loginApplication.
            return Ok();
        }

    }
}
