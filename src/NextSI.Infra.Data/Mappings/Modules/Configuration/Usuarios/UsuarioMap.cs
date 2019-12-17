using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasIndex(e => e.AreaId)
                .HasName("fk_usuario_area1_idx");

            builder.HasIndex(e => e.CalendarioTrabalhoId)
                .HasName("fk_usuario_calendario_trabalho1_idx");

            builder.HasIndex(e => e.DeleteUsuarioId)
                .HasName("fk_usuario_usuario3_idx");

            builder.HasIndex(e => e.FotoId)
                .HasName("fk_usuario_documento1_idx");

            builder.HasIndex(e => e.InsertUsuarioId)
                .HasName("fk_usuario_usuario1_idx");

            builder.HasIndex(e => e.ServidorLdapId)
                .HasName("fk_servidor_ldap_servidor_id");

            builder.HasIndex(e => e.UpdateUsuarioId)
                .HasName("fk_usuario_usuario2_idx");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Admin)
                .IsRequired()
                .HasColumnName("admin")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.AlterarSenhaProximoLogin)
                .HasColumnName("alterar_senha_proximo_login")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.AreaId)
                .HasColumnName("area_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.AssinaturaEmail)
                .HasColumnName("assinatura_email")
                .HasColumnType("longtext");

            builder.Property(e => e.Bloqueado)
                .IsRequired()
                .HasColumnName("bloqueado")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.CalendarioTrabalhoId)
                .HasColumnName("calendario_trabalho_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChaveIcs)
                .HasColumnName("chave_ics")
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.Property(e => e.CodigoExterno)
                .HasColumnName("codigo_externo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Cpf)
                .HasColumnName("cpf")
                .HasMaxLength(18)
                .IsUnicode(false);

            builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

            builder.Property(e => e.DeleteUsuarioId)
                .HasColumnName("delete_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.DtEsqueci).HasColumnName("dt_esqueci");

            builder.Property(e => e.EadPlataformaAlunoId)
                .HasColumnName("ead_plataforma_aluno_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.EadPlataformaDataHora).HasColumnName("ead_plataforma_data_hora");

            builder.Property(e => e.EadPlataformaSenha)
                .HasColumnName("ead_plataforma_senha")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.EadPlataformaUsuario)
                .HasColumnName("ead_plataforma_usuario")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Excluido)
                .IsRequired()
                .HasColumnName("excluido")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.FotoId)
                .HasColumnName("foto_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Idioma)
                .HasColumnName("idioma")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

            builder.Property(e => e.InsertUsuarioId)
                .HasColumnName("insert_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.LdapLogin)
                .HasColumnName("ldap_login")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Nivel)
                .HasColumnName("nivel")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("10");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.ReqSenhaIp)
                .HasColumnName("req_senha_ip")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Senha)
                .IsRequired()
                .HasColumnName("senha")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ServidorLdapId)
                .HasColumnName("servidor_ldap_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Telefone1)
                .HasColumnName("telefone1")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Telefone2)
                .HasColumnName("telefone2")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Telefone3)
                .HasColumnName("telefone3")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Telefone4)
                .HasColumnName("telefone4")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Tipo)
                .HasColumnName("tipo")
                .HasColumnType("int(11)");

            builder.Property(e => e.UltimoAcesso).HasColumnName("ultimo_acesso");

            builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

            builder.Property(e => e.UpdateUsuarioId)
                .HasColumnName("update_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.HasOne(d => d.Area)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("fk_usuario_area1");

            builder.HasOne(d => d.CalendarioTrabalho)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CalendarioTrabalhoId)
                .HasConstraintName("fk_usuario_calendario_trabalho1");

            builder.HasOne(d => d.ServidorLdap)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ServidorLdapId)
                .HasConstraintName("fk_servidor_ldap_servidor_id");

        }
    }
}