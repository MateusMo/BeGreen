using BeGreen.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeGreen.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginApplication _loginApplication;

        public LoginController(LoginApplication loginApplication)
        {
            _loginApplication = loginApplication;
        }

        [HttpPost]
        [Route("")]
        public IActionResult Login([FromQuery] string email, string senha)
        {
            if (string.IsNullOrEmpty(email))
                return BadRequest("Email inválido!");

            if (string.IsNullOrEmpty(senha))
                return BadRequest("Senha inválida!");

            var user = _loginApplication.Login(email, senha);

            if (user is null)
                NotFound("Email não encontrado!");

            return Ok();
        }

    }
}
