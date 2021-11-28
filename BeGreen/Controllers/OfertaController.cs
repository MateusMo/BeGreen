using AutoMapper;
using BeGreen.Application;
using BeGreen.Context;
using BeGreen.Dtos.Oferta;
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
        public List<Oferta> ObterOfertas()
        {
            List<Oferta> ofertas = _ofertaApplication.GetAll().ToList();

            return ofertas;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<Oferta> ObterOferta([FromQuery] int id)
        {
            var oferta = _ofertaApplication.Get(id);

            if (oferta is null)
                NotFound("Oferta não encontrada");

            return Ok(oferta);
        }

        [HttpPost]
        public IActionResult CadastrarOferta([FromBody] CreateOfertaDto ofertaDto)
        {
            var oferta = _mapper.Map<Oferta>(ofertaDto);

            try
            {
                _ofertaApplication.Add(oferta);
            }
            catch (Exception)
            {
                throw;
            }
            return BadRequest("Oferta já cadastrado!");
        }

        [HttpPut]
        public IActionResult AtualizarOferta([FromBody] UpdateOfertaDto ofertaDto)
        {
            var ofertaUpdate = _mapper.Map<Oferta>(ofertaDto);

            var oferta = _ofertaApplication.Get(ofertaUpdate.Id);

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

            return BadRequest("Ocorreu um erro ao atualizar o Oferta");
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeletarOferta([FromQuery] int id)
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
