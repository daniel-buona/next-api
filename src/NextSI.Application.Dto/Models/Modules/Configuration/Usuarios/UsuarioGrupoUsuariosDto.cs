namespace NextSI.Application.Dto.Models.Modules.Configuration.Usuarios
{
    public class UsuarioGrupoUsuariosDto
    {
        public int UsuarioId { get; set; }
        public int GrupoUsuariosId { get; set; }

        public virtual GrupoUsuariosDto GrupoUsuario { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
    }
}
