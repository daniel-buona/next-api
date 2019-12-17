namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class UsuarioProspect
    {
        public int UsuarioId { get; set; }
        public int ProspectId { get; set; }

        public virtual Prospect Prospect { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
