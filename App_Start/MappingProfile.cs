using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using StoresManagement.Dtos;
using StoresManagement.Models;

namespace StoresManagement.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Entity, EntityDto>();
            Mapper.CreateMap<EntityDto, Entity>();
        }
    }
}