using AutoMapper;
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
    public class CadastroPromocaoController : ControllerBase
    {
        private readonly ContextBase _context;

        private readonly IMapper _mapper;

        public CadastroPromocaoController(ContextBase contextBase, IMapper mapper)
        {
            _context = contextBase;
            _mapper = mapper;
        }

        
    }
}
