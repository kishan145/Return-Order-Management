using AutoMapper;
using ChargeProceesing.API.Models;
using ChargeProceesing.API.Models.Dtos;
using ChargeProceesing.API.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeProceesing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackProcessing : ControllerBase
    {
        private IPackRepository _pRepo;
        private readonly IMapper _mapper;

        public PackProcessing(IPackRepository pRepo, IMapper mapper)
        {
            _pRepo = pRepo;
            _mapper = mapper;

        }

        //[Authorize]
        [HttpGet]
        public IActionResult GetPackProcessings()
        {
            var objList = _pRepo.GetPackProcessings();

            var objDto = new List<PackModelDto>();

            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<PackModelDto>(obj));
            }
            return Ok(objDto);
        }

        [HttpGet("{pId:int}", Name = "GetPackProcessing")]
        public IActionResult GetPackProcessing(int pId)
        {
            var obj = _pRepo.GetPackProcessing(pId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<PackModelDto>(obj);
            return Ok(objDto);
        }

        [HttpPost]
        public IActionResult CreatePackProcessing([FromBody] PackModel comp)
        {
            
            if (comp == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //var obj = _pRepo.CreatePackProcessing(comp);

            var packProcessingObj = comp;
            if (!_pRepo.CreatePackProcessing(packProcessingObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {packProcessingObj.requestId}");
                return StatusCode(500, ModelState);
            }
            //return Ok(obj);
                
            return CreatedAtRoute("GetPackProcessing", new { pId = packProcessingObj.requestId }, packProcessingObj);
        }
    }
}
