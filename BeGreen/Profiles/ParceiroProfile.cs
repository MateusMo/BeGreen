using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeGreen.Models;
using BeGreen.Dtos.ParceiroDto;

namespace BeGreen.Profiles
{
    public class ParceiroProfile : Profile
    {
        public ParceiroProfile()
        {
            CreateMap<CreateParceiroDto, Parceiro>();
            CreateMap<Parceiro, CreateParceiroDto>();
            CreateMap<CreateParceiroDto, Parceiro>();
        }
    }
}
