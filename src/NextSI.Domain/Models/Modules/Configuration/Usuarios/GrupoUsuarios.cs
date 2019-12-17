using NextSI.Domain.Core.Models;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class GrupoUsuarios : BaseEntity
    {
        public string Nome { get; set; }
        public string Agenda { get; set; }
        public string Chamados { get; set; }
        public string Documentos { get; set; }
        public string Processos { get; set; }
        public string Projetos { get; set; }
        public string Crm { get; set; }
        public string Social { get; set; }
        public string TipoGrupoUsuario { get; set; }
        public string Inovacao { get; set; }

        public virtual ICollection<UsuarioGrupoUsuarios> Usuarios { get; set; }
    }
}
