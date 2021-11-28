using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeGreen.Models;
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
