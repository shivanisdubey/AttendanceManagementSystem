using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint1.Repositories;
using Sprint1.Models;

namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        [HttpGet]
        [Route("check login")]
        public bool CheckLogin(string Role, int EmployeeId, string Password)
        {
            return _loginRepository.CheckLogin(Role, EmployeeId, Password);
        }
    }
}
