namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class UsuarioFornecedor
    {
        public int UsuarioId { get; set; }
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
