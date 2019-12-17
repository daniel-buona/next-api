using NextSI.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public partial class Cliente: BaseEntity
    {
        public Cliente()
        {
            Usuarios = new HashSet<UsuarioCliente>();
        }

        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string EmailAgenda { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Telefone4 { get; set; }
        public int? LogoId { get; set; }
        public string Codigo { get; set; }
        public string Unidade { get; set; }
        public string Bloqueado { get; set; }
        public string Pessoa { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CodMunicipio { get; set; }
        public string Cep { get; set; }
        public string CodPais { get; set; }
        public string Cnpj { get; set; }
        public string Vat { get; set; }
        public string Inscricao { get; set; }
        public string IdEstrangeiro { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string DataFundacao { get; set; }
        public string Site { get; set; }
        public string EmailPrincipal { get; set; }
        public string Observacoes { get; set; }
        public string TipoOrgao { get; set; }
        public string Classificacao { get; set; }
        public string Qualificado { get; set; }
        public int? CondicaoPagamentoId { get; set; }
        public string DominioInteracao { get; set; }
        public int? EmpresaMatrizId { get; set; }
        public int? EmpresaFilialId { get; set; }
        public int? EmpresaGrupoId { get; set; }
        public string PossuiRestricao { get; set; }
        public DateTime? SincronismoHora { get; set; }
        public virtual EmpresaFilial EmpresaFilial { get; set; }
        public virtual EmpresaGrupo EmpresaGrupo { get; set; }
        public virtual EmpresaMatriz EmpresaMatriz { get; set; }
        public virtual ICollection<UsuarioCliente> Usuarios { get; set; }
    }
}
