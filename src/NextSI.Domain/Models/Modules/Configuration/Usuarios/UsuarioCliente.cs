namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class UsuarioCliente
    {
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
