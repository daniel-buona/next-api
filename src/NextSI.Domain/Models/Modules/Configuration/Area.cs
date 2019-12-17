using NextSI.Domain.Core.Models;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class Area: BaseEntity
    {
        public Area()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string Nome { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
