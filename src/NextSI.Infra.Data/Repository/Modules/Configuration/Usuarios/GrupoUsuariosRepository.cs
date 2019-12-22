using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;
using System;

namespace NextSI.Infra.Data.Repository.Modules.Configuration.Usuarios
{
    public class GrupoUsuariosRepository : Repository<GrupoUsuarios>, IGrupoUsuariosRepository
    {
        public GrupoUsuariosRepository(NextSIContext context)
            : base(context)
        {

        }

        public override void Remove(int id)
        {
            // TODO: Salvar a data de exclusão
            var obj = DbSet.Find(id);
            obj.DeleteHora = DateTime.Now;
            obj.Excluido = 'S';
            obj.Usuarios.Clear();
            DbSet.Remove(DbSet.Find(id));
        }
    }
}
