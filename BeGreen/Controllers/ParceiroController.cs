using AutoMapper;
using BeGreen.Application;
using BeGreen.Dtos.Parceiro;
using BeGreen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        public List<ReadParceiroDto> ObterParceiros()
        {
            List<Parceiro> parceiros = _parceiroApplication.GetAll().ToList();

            var readParceirosDto = _mapper.Map<List<ReadParceiroDto>>(parceiros);

            return readParceirosDto;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<ReadParceiroDto> ObterParceiro(int id)
        {
            var parceiro = _parceiroApplication.Get(id);

            var readParceiroDto = _mapper.Map<ReadParceiroDto>(parceiro);

            return Ok(readParceiroDto);
        }

        [HttpPost]
        public IActionResult CadastrarParceiro([FromBody] CreateParceiroDto parceiroDto)
        {
            var atualizarParceiro = _mapper.Map<Parceiro>(parceiroDto);

            var parceiro = _parceiroApplication.ObterEmail(atualizarParceiro.Email);

            if (parceiro is null)
            {
                var login = new Login
                {
                    Email = atualizarParceiro.Email.ToLower(),
                    Senha = atualizarParceiro.Senha,
                    TipoCadastro = atualizarParceiro.TipoCadastro
                };

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
                parceiro.Login.Email = atualizarParceiro.Email;
                parceiro.Login.Senha = atualizarParceiro.Senha;

                _loginApplication.Update(parceiro.Login);

                parceiro.Cnpj = atualizarParceiro.Cnpj;
                parceiro.Ramo = atualizarParceiro.Ramo;
                parceiro.Nome = atualizarParceiro.Nome;

                parceiro.Cep = parceiroDto.Cep;
                parceiro.Complemento = parceiroDto.Complemento;
                parceiro.Numero = parceiroDto.Numero;
                parceiro.Logradouro = parceiroDto.Logradouro;

                _parceiroApplication.Update(parceiro);

                return Ok("Parceiro atualizado com sucesso!");
            }

            return BadRequest("Ocorreu um erro ao atualizar o parceiro");
        }

    }
}
