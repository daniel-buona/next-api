using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Repository.Modules.Configuration.Usuarios
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(NextSIContext context)
            : base(context)
        {

        }
    }
}