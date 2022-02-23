using AutoMapper;
using BeGreen.Application.Applications;
using BeGreen.Dtos.Oferta;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeGreen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioController : ControllerBase
    {
        private readonly RelatorioApplication _relatorioApplication;

        private readonly IMapper _mapper;

        public RelatorioController(RelatorioApplication relatorioApplication, IMapper mapper)
        {
            _relatorioApplication = relatorioApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<ReadOfertaDto>> ListarOfertas()
        {
            var ofertas = await _relatorioApplication.ListarOfertas();

            var ofertasRead = _mapper.Map<List<ReadOfertaDto>>(ofertas);

            return ofertasRead;
        }

    }
}
