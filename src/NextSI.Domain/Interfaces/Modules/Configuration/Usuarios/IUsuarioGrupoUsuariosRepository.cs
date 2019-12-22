using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Domain.Interfaces.Modules.Configuration.Usuarios
{
    public interface IUsuarioGrupoUsuariosRepository : IRepository<UsuarioGrupoUsuarios>
    {
        public void Remove(UsuarioGrupoUsuarios usuarioGrupo);
    }
}
