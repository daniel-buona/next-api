using NextSI.Domain.Core.Models;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class EmpresaMatriz: BaseEntity
    {
        public string Nome { get; set; }
        public int EmpresaGrupoId { get; set; }

        public virtual EmpresaGrupo EmpresaGrupo { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }

    }
}
