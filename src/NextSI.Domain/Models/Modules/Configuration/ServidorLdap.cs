using NextSI.Domain.Core.Models;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class ServidorLdap: BaseEntity
    {
        public ServidorLdap()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int? Porta { get; set; }
        public string FiltroConexao { get; set; }
        public string BaseDn { get; set; }
        public int? EmpresaGrupoId { get; set; }
        public int? EmpresaMatrizId { get; set; }
        public int? EmpresaFilialId { get; set; }
        public string Dominio { get; set; }
        public string UsuarioLdap { get; set; }
        public string SenhaLdap { get; set; }

        public virtual EmpresaFilial EmpresaFilial { get; set; }
        public virtual EmpresaGrupo EmpresaGrupo { get; set; }
        public virtual EmpresaMatriz EmpresaMatriz { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
