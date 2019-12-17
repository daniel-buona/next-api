using Microsoft.AspNetCore.Mvc;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Application.Interfaces.Modules.Configuration.Usuarios;
using System.Collections.Generic;
using System.Linq;

namespace NextSI.Services.Api.Controllers.Modules.Configuration.Usuarios
{
    [Route("api/Module/Configuration/Usuarios/[controller]")]
    [ApiController]
    public class UsuarioController : ApiController
    {
        private IUsuarioAppService _usuariosAppService;

        public UsuarioController(IUsuarioAppService usuariosAppService)
        {
            _usuariosAppService = usuariosAppService;
        }

        [HttpGet]
        [Route("usuario-management")]
        public IActionResult Get()
        {
            List<UsuarioDto> model = _usuariosAppService.GetAll().ToList();
            return Response(model);
        }

        [HttpGet]
        [Route("usuario-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _usuariosAppService.GetById(id);

            return Response(model);
        }

        [HttpPost]
        [Route("usuario-management")]
        public IActionResult Post([FromBody]UsuarioDto model)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(model);
            }
            return Response(_usuariosAppService.Update(model));
        }
    }
}