using AutoMapper;
using BeGreen.Application;
using BeGreen.Context;
using BeGreen.Dtos.ParceiroDto;
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
    public class ParceiroController : ControllerBase
    {
        private readonly ParceiroApplication _parceiroApplication;
        private readonly LoginApplication _loginApplication;

        private readonly IMapper _mapper;

        public ParceiroController(IMapper mapper, 
            ParceiroApplication parceiroApplication, 
            LoginApplication loginApplication)
        {
            _mapper = mapper;
            _parceiroApplication = parceiroApplication;
            _loginApplication = loginApplication;
        }

        [HttpGet]
        public List<Parceiro> ObterParceiros()
        {
            List<Parceiro> parceiros = _parceiroApplication.GetAll().ToList();

            return parceiros;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Parceiro> ObterParceiro([FromQuery] int id)
        {
            var parceiro = _parceiroApplication.Get(id);

            return Ok(parceiro);
        }

        [HttpPost]
        public IActionResult CadastrarParceiro([FromBody] CreateParceiroDto parceiroDto)
        {
            var atualizarParceiro = _mapper.Map<Parceiro>(parceiroDto);

            var parceiro = _parceiroApplication.ObterEmail(atualizarParceiro.Email);

            if (parceiro is null)
            {
                var login = new Login();

                login.Email = atualizarParceiro.Email;
                login.Senha = atualizarParceiro.Senha;
                login.TipoCadastro = atualizarParceiro.TipoCadastro;

                _loginApplication.Add(login);

                atualizarParceiro.CodigoLogin = login.Id;

                _parceiroApplication.Add(atualizarParceiro);

                return Ok("Parceiro cadastrado com sucesso!");
            }

            return BadRequest("Parceiro já cadastrado!");
        }

        [HttpPut]
        public IActionResult AtualizarParceiro([FromBody] UpdateParceiroDto parceiroDto)
        {
            var atualizarParceiro = _mapper.Map<Parceiro>(parceiroDto);

            var parceiro = _parceiroApplication.ObterEmail(atualizarParceiro.Email);

            if (parceiro is not null)
            {
                parceiro.Login.Email = atualizarParceiro.Login.Email;
                parceiro.Login.Senha = atualizarParceiro.Login.Senha;

                _loginApplication.Update(parceiro.Login);

                parceiro.Cnpj = atualizarParceiro.Cnpj;
                parceiro.Email = atualizarParceiro.Email;
                parceiro.Ramo = atualizarParceiro.Ramo;
                parceiro.Nome = atualizarParceiro.Nome;

                var endereco = parceiro.Enderecos.FirstOrDefault(x => x.Cep == parceiroDto.EnderecoDto.Cep);

                endereco.Cep = parceiroDto.EnderecoDto.Cep;
                endereco.Complemento = parceiroDto.EnderecoDto.Complemento;
                endereco.Numero = parceiroDto.EnderecoDto.Numero;
                endereco.Lagradouro = parceiroDto.EnderecoDto.Lagradouro;

                _parceiroApplication.Update(parceiro);

                return Ok("Parceiro atualizado com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao atualizar o parceiro");
        }

    }
}
