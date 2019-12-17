namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class UsuarioEmpresa
    {
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }

        public virtual EmpresaFilial Empresa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
