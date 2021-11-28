using BeGreen.Application;
using BeGreen.Dtos.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeGreen.Controllers
{
    [ApiController]
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
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromBody] ReadLoginDto login)
        {
            if (string.IsNullOrEmpty(login.Email))
                return BadRequest("Email inválido!");

            if (string.IsNullOrEmpty(login.Senha))
                return BadRequest("Senha inválida!");

            var user = _loginApplication.Login(login.Email, login.Senha);

            if (user is null)
                return NotFound("Email não encontrado!");

            user.Senha = "";

            if (user.Usuario is not null)
            {
                return new
                {
                    nome = user.Usuario.Nome,
                    email = user.Email,
                    tipoCadastro = user.TipoCadastro
                };
            }

            return new
            {
                nome = user.Parceiro.Nome,
                email = user.Email,
                tipoCadastro = user.TipoCadastro
            };
        }

    }
}
