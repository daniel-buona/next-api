using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using System.Collections.Generic;

namespace NextSI.Application.Interfaces.Modules.Configuration.Usuarios
{
    public interface IGrupoUsuariosAppService
    {
        GrupoUsuariosDto Register(GrupoUsuariosDto Model);
        List<GrupoUsuariosDto> GetAll();
        GrupoUsuariosDto GetById(int Id);
        GrupoUsuariosDto Update(GrupoUsuariosDto Model);
        void Remove(int Int);
    }
}
