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
    public class ServidorLdapController : ApiController
    {
        private IServidorLdapAppService _servidorLdapAppService;


        public ServidorLdapController(IServidorLdapAppService servidorLdapAppService)
        {
            _servidorLdapAppService = servidorLdapAppService;
        }

        [HttpGet]
        [Route("servidorldap-management")]
        public IActionResult Get()
        {
            List<ServidorLdapDto> model = _servidorLdapAppService.GetAll().ToList();
            return Response(model);
        }

        [HttpGet]
        [Route("servidorldap-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _servidorLdapAppService.GetById(id);

            return Response(model);
        }
    }
}