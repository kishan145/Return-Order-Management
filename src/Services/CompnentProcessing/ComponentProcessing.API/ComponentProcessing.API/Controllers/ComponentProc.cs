using AutoMapper;
using ComponentProcessing.API.Models;
using ComponentProcessing.API.Models.Dtos;
using ComponentProcessing.API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentProc : Controller
    {
        private IComponentProcessingRepository _cpRepo;
        private readonly IMapper _mapper;

        public ComponentProc(IComponentProcessingRepository cpRepo, IMapper mapper)
        {
            _cpRepo = cpRepo;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetComponentProcessings()
        {
            var objList = _cpRepo.GetComponentProcessings();

            var objDto = new List<ComponentProcessingModelDto>();

            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<ComponentProcessingModelDto>(obj));
            }
            return Ok(objDto);
        }

        [HttpGet("{cpId:int}",Name = "GetComponentProcessing")]
        public IActionResult GetComponentProcessing(int cpId)
        {
            var obj = _cpRepo.GetComponentProcessing(cpId);
            if(obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<ComponentProcessingModelDto>(obj);
            return Ok(objDto);
        }

        [HttpPost]
        public IActionResult CreateComponentProcessing([FromBody] CreateDto compDto)
        {
            if(compDto == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var componentProcessingObj = _mapper.Map<ComponentProcessingModel>(compDto);
            if(!_cpRepo.CreateComponentProcessing(componentProcessingObj))
            {
                ModelState.AddModelError("",$"Something went wrong when saving the record {componentProcessingObj.name}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetComponentProcessing", new { cpId = componentProcessingObj.requestId }, componentProcessingObj);
        }

        [HttpPatch("{cpId:int}", Name = "UpdateComponentProcessing")]
        public IActionResult UpdateComponentProcessing(int cpID,[FromBody] UpdateDto compDto)
        {
            if (compDto == null || cpID != compDto.requestId)
            {
                return BadRequest(ModelState);
            }

            var componentProcessingObj = _mapper.Map<ComponentProcessingModel>(compDto);
            if (!_cpRepo.UpdateComponentProcessing(componentProcessingObj))
            {
                ModelState.AddModelError("", $"Something went wrong when updating the record {componentProcessingObj.name}");
                return StatusCode(500, ModelState);
            }
            return NoContent();

        }

    }
}
