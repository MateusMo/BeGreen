using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeGreen.Models;
using BeGreen.Dtos.Usuario;

namespace BeGreen.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateLoginDto, Usuario>();
            CreateMap<Usuario, ReadLoginDto>();
            CreateMap<UpdateLoginDto, Usuario>();
        }
    }
}
