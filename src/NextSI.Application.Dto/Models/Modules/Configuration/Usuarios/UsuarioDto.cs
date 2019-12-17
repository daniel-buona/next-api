using System;
using System.Collections.Generic;

namespace NextSI.Application.Dto.Models.Modules.Configuration.Usuarios
{
    public class UsuarioDto : BaseDto
    {
        public UsuarioDto()
        {
            Grupos = new HashSet<UsuarioGrupoUsuariosDto>();
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

        public AreaDto Area { get; set; }
        public CalendarioTrabalhoDto CalendarioTrabalho { get; set; }
        public ServidorLdapDto ServidorLdap { get; set; }
        public virtual ICollection<UsuarioGrupoUsuariosDto> Grupos { get; set; }
    }
}
