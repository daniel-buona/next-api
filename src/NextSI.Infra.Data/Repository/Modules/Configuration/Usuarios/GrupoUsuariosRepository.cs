using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Repository.Modules.Configuration.Usuarios
{
    public class GrupoUsuariosRepository : Repository<GrupoUsuarios>, IGrupoUsuariosRepository
    {
        public GrupoUsuariosRepository(NextSIContext context)
            : base(context)
        {

        }
    }
}
