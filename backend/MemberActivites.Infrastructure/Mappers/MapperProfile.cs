using AutoMapper;
using MemberActivities.Domain.DTOs;
using MemberActivities.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<MemberDTO, Member>().ReverseMap();
        }
    }
}
