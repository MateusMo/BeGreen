using AutoMapper;
using BeGreen.Application;
using BeGreen.Dtos.Oferta;
using BeGreen.Dtos.Parceiro;
using BeGreen.Models;
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

        private readonly ParceiroApplication _parceiroApplication;

        private readonly IMapper _mapper;

        public OfertaController(IMapper mapper, OfertaApplication ofertaApplication, ParceiroApplication parceiroApplication)
        {
            _mapper = mapper;
            _ofertaApplication = ofertaApplication;
            _parceiroApplication = parceiroApplication;
        }

        [HttpGet]
        [Route("OfertasParceiro")]
        public ActionResult<ReadOfertaDto> ListarOfertas(int codigoParceiro)
        {
            var ofertas = new List<Oferta>();

            if (codigoParceiro != 0)
                ofertas = _ofertaApplication.ObterOfertasParceiro(codigoParceiro).ToList();

            if (ofertas.Any() is false)
                return NotFound("Nenhuma oferta cadastrada!");

            var result = _mapper.Map<List<ReadOfertaDto>>(ofertas);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<ReadOfertaDto> ObterOferta(int id)
        {
            var oferta = _ofertaApplication.Get(id);
            var parceiro = _parceiroApplication.Get(oferta.CodigoParceiro);

            var ofertaRead = _mapper.Map<ReadOfertaDto>(oferta);
            ofertaRead.Parceiro = _mapper.Map<ReadParceiroDto>(parceiro);

            if (oferta is null)
                NotFound("Oferta não encontrada");

            return Ok(ofertaRead);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CadastrarOferta([FromBody] CreateOfertaDto ofertaDto)
        {
            var oferta = _mapper.Map<Oferta>(ofertaDto);

            _ofertaApplication.Add(oferta);

            var ofertaRead = _mapper.Map<ReadOfertaDto>(oferta);

            return Ok(ofertaRead);
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

                return Ok(ofertaUpdate);
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
