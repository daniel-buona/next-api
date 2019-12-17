using NextSI.Domain.Core.Models;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class EmpresaGrupo: BaseEntity
    {
        public EmpresaGrupo()
        {
            EmpresaMatriz = new HashSet<EmpresaMatriz>();
        }

        public string Nome { get; set; }

        public virtual ICollection<EmpresaMatriz> EmpresaMatriz { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
