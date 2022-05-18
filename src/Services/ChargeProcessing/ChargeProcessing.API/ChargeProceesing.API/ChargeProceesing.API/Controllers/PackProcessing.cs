using AutoMapper;
using ChargeProceesing.API.Models;
using ChargeProceesing.API.Models.Dtos;
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
        //------------------------------------------------------------------------
        [HttpGet]
        public IActionResult GetPackProcessing([FromQuery] GetDto data)
        {

            if (data.comType == "Integral")
            {
                data.packageCharges = 100 * data.quantity;
                data.deliveryCharges = 200 * data.quantity;
            }
            else
            {
                data.packageCharges = 50 * data.quantity;
                data.deliveryCharges = 100 * data.quantity;
            }
            return Ok(data);
        }
        //--------------------------------------------------------------------------------------
    }
}
