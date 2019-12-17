namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class UsuarioGrupoUsuarios
    {
        public int UsuarioId { get; set; }
        public int GrupoUsuariosId { get; set; }

        public virtual GrupoUsuarios GrupoUsuarios { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
