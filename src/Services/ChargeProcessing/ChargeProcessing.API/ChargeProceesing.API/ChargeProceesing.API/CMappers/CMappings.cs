using AutoMapper;
using ChargeProceesing.API.Models;
using ChargeProceesing.API.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeProceesing.API.CMappers
{
    public class CMappings:Profile
    {
        public CMappings()
        {
            CreateMap<PackModel, PackModelDto>().ReverseMap();
        }
    }
}
