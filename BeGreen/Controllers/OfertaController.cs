using AutoMapper;
using BeGreen.Application;
using BeGreen.Dtos.Oferta;
using BeGreen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BeGreen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfertaController : ControllerBase
    {
        private readonly OfertaApplication _ofertaApplication;

        private readonly IMapper _mapper;

        public OfertaController(IMapper mapper, OfertaApplication ofertaApplication)
        {
            _mapper = mapper;
            _ofertaApplication = ofertaApplication;
        }

        [HttpGet]
        [Route("OfertasParceiro")]
        public ActionResult<Oferta> ListarOfertas(int codigoParceiro)
        {
            var ofertas = new List<Oferta>();

            if (codigoParceiro != 0)
                ofertas = _ofertaApplication.ObterOfertasParceiro(codigoParceiro).ToList();

            if (ofertas.Any() is false)
                return NotFound("Nenhuma oferta cadastrada!");

            var result = _mapper.Map<ReadOfertaDto>(ofertas);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Oferta> ObterOferta(int id)
        {
            var oferta = _ofertaApplication.Get(id);

            if (oferta is null)
                NotFound("Oferta não encontrada");

            return Ok(oferta);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CadastrarOferta([FromBody] CreateOfertaDto ofertaDto)
        {
            var oferta = _mapper.Map<Oferta>(ofertaDto);

            _ofertaApplication.Add(oferta);

            return Ok(oferta);
        }

        [HttpPut]
        [Route("")]
        public IActionResult AtualizarOferta([FromBody] UpdateOfertaDto ofertaDto)
        {
            var ofertaUpdate = _mapper.Map<Oferta>(ofertaDto);

            var oferta = _ofertaApplication.Get(ofertaDto.Id);

            if (oferta is not null)
            {
                oferta.Titulo = ofertaUpdate.Titulo;
                oferta.Descricao = ofertaUpdate.Descricao;
                oferta.Latitude = ofertaUpdate.Latitude;
                oferta.Longitude = ofertaUpdate.Longitude;
                oferta.DataInicio = DateTime.Now;
                oferta.DataFinal = ofertaUpdate.DataFinal;

                _ofertaApplication.Update(oferta);

                return Ok("Oferta atualizada com sucesso!");
            }

            return NotFound("Oferta não encontrada!");
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeletarOferta(int id)
        {
            var oferta = _ofertaApplication.Get(id);

            try
            {
                if (oferta is not null)
                    _ofertaApplication.Delete(oferta.Id);

                return Ok("Oferta excluída com sucesso!");
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro ao atualizar o Oferta");
            }
        }

    }
}
