using AutoMapper;
using FarmaciaFinal.Dtos;
using FarmaciaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaFinal.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain model to Dto
            Mapper.CreateMap<OrdenVenta, OrdenVentaDto>();

            //Resolving exception for updating id
            Mapper.CreateMap<OrdenVentaDto, OrdenVenta>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}