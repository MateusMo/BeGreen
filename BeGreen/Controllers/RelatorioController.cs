using BeGreen.Application;
using BeGreen.Models;
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

        public RelatorioController(RelatorioApplication relatorioApplication)
        {
            _relatorioApplication = relatorioApplication;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<Oferta>> ListarOfertas()
        {
            var ofertas = await _relatorioApplication.ListarOfertas();

            return ofertas;
        }

    }
}
