using AutoMapper;
using BeGreen.Domain.Entidades;
using BeGreen.Dtos.Oferta;

namespace BeGreen.Profiles
{
    public class OfertaProfile : Profile
    {
        public OfertaProfile()
        {
            CreateMap<CreateOfertaDto, Oferta>();
            CreateMap<Oferta, ReadOfertaDto>();
            CreateMap<UpdateOfertaDto, Oferta>();
        }
    }
}
