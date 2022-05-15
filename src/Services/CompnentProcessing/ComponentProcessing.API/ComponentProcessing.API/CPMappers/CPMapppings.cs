using AutoMapper;
using ComponentProcessing.API.Models;
using ComponentProcessing.API.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessing.API.CPMappers
{
    public class CPMapppings: Profile
    {
        public CPMapppings()
        {
            CreateMap<ComponentProcessingModel, ComponentProcessingModelDto>().ReverseMap();
            CreateMap<ComponentProcessingModel, CreateDto>().ReverseMap();
            CreateMap<ComponentProcessingModel, UpdateDto>().ReverseMap();
        }
    }
}
