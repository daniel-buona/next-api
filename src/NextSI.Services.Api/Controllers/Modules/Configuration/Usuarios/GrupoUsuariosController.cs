using Microsoft.AspNetCore.Mvc;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Application.Interfaces.Modules.Configuration.Usuarios;

namespace NextSI.Services.Api.Controllers.Modules.Configuration.Usuarios
{
    [Route("api/Module/Configuration/[controller]")]
    [ApiController]
    public class GrupoUsuariosController : ApiController
    {
        private readonly IGrupoUsuariosAppService _grupoUsuariosAppService;

        public GrupoUsuariosController(
            IGrupoUsuariosAppService grupoUsuariosAppService)
        {
            _grupoUsuariosAppService = grupoUsuariosAppService;

        }

        [HttpGet]
        [Route("grupo-usuarios-management")]
        public IActionResult Get()
        {
            return Response(_grupoUsuariosAppService.GetAll());
        }

        [HttpGet]
        [Route("grupo-usuarios-management/{id:int}")]
        public IActionResult Get(int id)
        {
            var model = _grupoUsuariosAppService.GetById(id);

            return Response(model);
        }

        [HttpPost]
        [Route("grupo-usuarios-management")]
        public IActionResult Post([FromBody]GrupoUsuariosDto model)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(model);
            }

            return Response(_grupoUsuariosAppService.Register(model));
        }

        [HttpPut]
        [Route("grupo-usuarios-management")]
        public IActionResult Put([FromBody]GrupoUsuariosDto model)
        {
            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(model);
            }

            return Response(_grupoUsuariosAppService.Update(model));
        }

        [HttpDelete]
        [Route("grupo-usuarios-management")]
        public IActionResult Delete(int id)
        {
            _grupoUsuariosAppService.Remove(id);

            return Response();
        }

    }
}
