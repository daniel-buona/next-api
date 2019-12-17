using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration;

namespace NextSI.Services.Api.Controllers.Modules.Configuration
{
    [Route("api/Module/Configuration/[controller]")]
    [ApiController]
    public class AreaController : ApiController
    {
        private IAreaAppService _areaAppService;

        public AreaController(IAreaAppService areaAppService)
        {
            _areaAppService = areaAppService;
        }

        [HttpGet]
        [Route("area-management")]
        public IActionResult Get()
        {
            List<AreaDto> model = _areaAppService.GetAll().ToList();
            return Response(model);
        }

        [HttpGet]
        [Route("area-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _areaAppService.GetById(id);

            return Response(model);
        }
    }
}