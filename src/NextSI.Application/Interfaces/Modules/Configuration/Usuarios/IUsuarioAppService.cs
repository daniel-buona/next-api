using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using System.Linq;

namespace NextSI.Application.Interfaces.Modules.Configuration.Usuarios
{
    public interface IUsuarioAppService
    {
        IQueryable<UsuarioDto> GetAll();
        UsuarioDto GetById(int Id);
        UsuarioDto Update(UsuarioDto Model);
    }
}
