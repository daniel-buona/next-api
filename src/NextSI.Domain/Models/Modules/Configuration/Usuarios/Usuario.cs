using NextSI.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace NextSI.Domain.Models.Modules.Configuration
{
    public class Usuario : BaseEntity
    {
        public Usuario()
        {
            Grupos = new HashSet<UsuarioGrupoUsuarios>();
            Clientes = new HashSet<UsuarioCliente>();
            Empresas = new HashSet<UsuarioEmpresa>();
            Fornecedores = new HashSet<UsuarioFornecedor>();
            Prospects= new HashSet<UsuarioProspect>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Bloqueado { get; set; }
        public string Admin { get; set; }
        public int? AreaId { get; set; }
        public int? CalendarioTrabalhoId { get; set; }
        public int? Tipo { get; set; }
        public DateTime? DtEsqueci { get; set; }
        public string ReqSenhaIp { get; set; }
        public int? Nivel { get; set; }
        public int? FotoId { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Telefone4 { get; set; }
        public string Cpf { get; set; }
        public string Idioma { get; set; }
        public string AssinaturaEmail { get; set; }
        public string LdapLogin { get; set; }
        public int? ServidorLdapId { get; set; }
        public string AlterarSenhaProximoLogin { get; set; }
        public string ChaveIcs { get; set; }
        public string CodigoExterno { get; set; }
        public int? EadPlataformaAlunoId { get; set; }
        public string EadPlataformaUsuario { get; set; }
        public string EadPlataformaSenha { get; set; }
        public DateTime? EadPlataformaDataHora { get; set; }
        public DateTime? UltimoAcesso { get; set; }

        public virtual Area Area { get; set; }
        public virtual CalendarioTrabalho CalendarioTrabalho { get; set; }
        public virtual ServidorLdap ServidorLdap { get; set; }

        public virtual ICollection<UsuarioGrupoUsuarios> Grupos { get; set; }
        public virtual ICollection<UsuarioCliente> Clientes { get; set; }
        public virtual ICollection<UsuarioEmpresa> Empresas { get; set; }
        public virtual ICollection<UsuarioFornecedor> Fornecedores { get; set; }
        public virtual ICollection<UsuarioProspect> Prospects { get; set; }

    }
}
