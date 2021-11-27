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
    public class UsuarioController : ControllerBase
    {
        private readonly ContextBase _context;

        private readonly IMapper _mapper;

        public UsuarioController(ContextBase contextBase, IMapper mapper)
        {
            _context = contextBase;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Usuario>> ObterUsuarios()
        {
            List<Usuario> usuarios = await _context.Usuarios.ToListAsync();

            return usuarios;
        }
        
    }
}
