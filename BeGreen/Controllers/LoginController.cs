using BeGreen.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public ActionResult<dynamic> Login([FromQuery] string email, string senha)
        {
            if (string.IsNullOrEmpty(email))
                return BadRequest("Email inválido!");

            if (string.IsNullOrEmpty(senha))
                return BadRequest("Senha inválida!");

            var user = _loginApplication.Login(email, senha);

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
