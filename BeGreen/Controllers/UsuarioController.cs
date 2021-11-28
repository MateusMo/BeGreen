using AutoMapper;
using BeGreen.Application;
using BeGreen.Context;
using BeGreen.Dtos.Usuario;
using BeGreen.Enums;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
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
        public List<Usuario> ObterUsuarios()
        {
            List<Usuario> usuarios = _usuarioApplication.GetAll().ToList();

            return usuarios;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Usuario> ObterUsuario([FromQuery]int id)
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
                var login = new Login();

                login.Email = novoUsuario.Email;
                login.Senha = novoUsuario.Senha;
                login.TipoCadastro = novoUsuario.TipoCadastro;

                _loginApplication.Add(login);

                novoUsuario.CodigoLogin = login.Id;

                _usuarioApplication.Add(novoUsuario);

                return Ok("Usuário cadastrado com sucesso!");
            }

            return BadRequest("Usuário já cadastrado!");
        }
        
    }
}
