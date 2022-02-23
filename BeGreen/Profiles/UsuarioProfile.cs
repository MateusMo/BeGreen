using AutoMapper;
using BeGreen.Domain.Entidades;
using BeGreen.Dtos.Usuario;

namespace BeGreen.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<UpdateUsuarioDto, Usuario>();
        }
    }
}
