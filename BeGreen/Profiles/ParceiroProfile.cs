using AutoMapper;
using BeGreen.Domain.Entidades;
using BeGreen.Dtos.Parceiro;

namespace BeGreen.Profiles
{
    public class ParceiroProfile : Profile
    {
        public ParceiroProfile()
        {
            CreateMap<CreateParceiroDto, Parceiro>();
            CreateMap<Parceiro, ReadParceiroDto>();
            CreateMap<UpdateParceiroDto, Parceiro>();
        }
    }
}
