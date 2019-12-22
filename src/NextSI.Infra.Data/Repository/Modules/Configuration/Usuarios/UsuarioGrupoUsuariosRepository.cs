using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Repository.Modules.Configuration.Usuarios
{
    public class UsuarioGrupoUsuariosRepository : Repository<UsuarioGrupoUsuarios>, IUsuarioGrupoUsuariosRepository
    {
        public UsuarioGrupoUsuariosRepository(NextSIContext context)
            : base(context)
        {

        }

        public void Remove(UsuarioGrupoUsuarios usuarioGrupo)
        {
            // TODO: Salvar a data de exclusão
            var obj = DbSet.Find(usuarioGrupo.UsuarioId, usuarioGrupo.GrupoUsuariosId);
            DbSet.Remove(obj);
        }
    }
}