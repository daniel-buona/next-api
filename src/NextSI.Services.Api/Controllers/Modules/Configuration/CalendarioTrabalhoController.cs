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
    public class CalendarioTrabalhoController : ApiController
    {
        private ICalendarioTrabalhoAppService _calendarioTrabalhoAppService;


        public CalendarioTrabalhoController(ICalendarioTrabalhoAppService calendarioTrabalhoAppService)
        {
            _calendarioTrabalhoAppService = calendarioTrabalhoAppService;
        }

        [HttpGet]
        [Route("calendario-trabalho-management")]
        public IActionResult Get()
        {
            List<CalendarioTrabalhoDto> model = _calendarioTrabalhoAppService.GetAll().ToList();
            return Response(model);
        }

        [HttpGet]
        [Route("calendario-trabalho-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _calendarioTrabalhoAppService.GetById(id);

            return Response(model);
        }
    }
}