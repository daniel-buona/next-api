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
    public class TipoEntidadeController : ApiController
    {
        private ITipoEntidadeAppService _tipoEntidadeAppService;

        public TipoEntidadeController(ITipoEntidadeAppService tipoEntidadeAppService)
        {
            _tipoEntidadeAppService = tipoEntidadeAppService;
        }

        [HttpGet]
        [Route("area-management")]
        public IActionResult Get()
        {
            List<TipoEntidadeDto> model = _tipoEntidadeAppService.Get();
            return Response(model);
        }

        [HttpGet]
        [Route("area-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _tipoEntidadeAppService.Get(id);

            return Response(model);
        }
    }
}