using AutoMapper;
using BeGreen.Application;
using BeGreen.Dtos.Usuario;
using BeGreen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BeGreen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioApplication _usuarioApplication;
        private readonly LoginApplication _loginApplication;
        private readonly IMapper _mapper;

        public UsuarioController(IMapper mapper, 
            UsuarioApplication usuarioApplication, 
            LoginApplication loginApplication)
        {
            _mapper = mapper;
            _usuarioApplication = usuarioApplication;
            _loginApplication = loginApplication;
        }

        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = _usuarioApplication.GetAll().ToList();

            return usuarios;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Usuario> ObterUsuario(int id)
        {
            var usuario = _usuarioApplication.Get(id);

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            var novoUsuario = _mapper.Map<Usuario>(usuarioDto);

            var usuario = _usuarioApplication.ObterEmail(novoUsuario.Email);

            if (usuario is null)
            {
                var login = new Login
                {
                    Email = novoUsuario.Email,
                    Senha = novoUsuario.Senha,
                    TipoCadastro = novoUsuario.TipoCadastro
                };

                _loginApplication.Add(login);

                novoUsuario.CodigoLogin = login.Id;

                _usuarioApplication.Add(novoUsuario);

                return Ok("Usuário cadastrado com sucesso!");
            }

            return BadRequest("Usuário já cadastrado!");
        }
        
    }
}
