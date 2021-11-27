using AutoMapper;
using BeGreen.Application;
using BeGreen.Context;
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

        private readonly IMapper _mapper;

        public ParceiroController(IMapper mapper, ParceiroApplication parceiroApplication)
        {
            _mapper = mapper;
            _parceiroApplication = parceiroApplication;
        }

        [HttpGet]
        public List<Parceiro> ObterParceiros()
        {
            List<Parceiro> parceiros = _parceiroApplication.GetAll().ToList();

            return parceiros;
        }
        
    }
}
