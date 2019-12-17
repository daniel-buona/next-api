using NextSI.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class EmpresaFilial: BaseEntity
    {
        public EmpresaFilial()
        {
            Usuarios = new HashSet<UsuarioEmpresa>();
        }

        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Site { get; set; }
        public string EmailPrincipal { get; set; }
        public int? LogoId { get; set; }
        public int? LogoCabecalhoId { get; set; }
        public int? LogoRodapeId { get; set; }
        public int? LogoMarcacaoId { get; set; }
        public string TextoRodape { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CodMunicipio { get; set; }
        public string CodPais { get; set; }
        public string Padrao { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Telefone4 { get; set; }
        public string ArquivoLicenca { get; set; }
        public DateTime? UltimoSincronismo { get; set; }
        public DateTime? UltimoPing { get; set; }
        public string DominioInteracao { get; set; }

        public virtual ICollection<UsuarioEmpresa> Usuarios { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
