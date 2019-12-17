using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration
{
    public class ServidorLdapMap : IEntityTypeConfiguration<ServidorLdap>
    {
        public void Configure(EntityTypeBuilder<ServidorLdap> builder)
        {
                builder.ToTable("servidor_ldap");

                builder.HasIndex(e => e.DeleteUsuarioId)
                    .HasName("fk_usuario_3_idx");

                builder.HasIndex(e => e.EmpresaFilialId)
                    .HasName("fk_servidor_ldap_empresa_filial_idx");

                builder.HasIndex(e => e.EmpresaGrupoId)
                    .HasName("fk_servidor_ldap_empresa_grupo_idx");

                builder.HasIndex(e => e.EmpresaMatrizId)
                    .HasName("fk_servidor_ldap_empresa_matriz_idx");

                builder.HasIndex(e => e.InsertUsuarioId)
                    .HasName("fk_usuario_1_idx");

                builder.HasIndex(e => e.UpdateUsuarioId)
                    .HasName("fk_usuario_2_idx");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.BaseDn)
                    .HasColumnName("base_dn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

                builder.Property(e => e.DeleteUsuarioId)
                    .HasColumnName("delete_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Dominio)
                    .HasColumnName("dominio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.EmpresaFilialId)
                    .HasColumnName("empresa_filial_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.EmpresaGrupoId)
                    .HasColumnName("empresa_grupo_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.EmpresaMatrizId)
                    .HasColumnName("empresa_matriz_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                builder.Property(e => e.Excluido)
                    .HasColumnName("excluido")
                    .HasColumnType("char(1)");

                builder.Property(e => e.FiltroConexao)
                    .HasColumnName("filtro_conexao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

                builder.Property(e => e.InsertUsuarioId)
                    .HasColumnName("insert_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                builder.Property(e => e.Porta)
                    .HasColumnName("porta")
                    .HasColumnType("int(11)");

                builder.Property(e => e.SenhaLdap)
                    .HasColumnName("senha_ldap")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

                builder.Property(e => e.UpdateUsuarioId)
                    .HasColumnName("update_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.UsuarioLdap)
                    .HasColumnName("usuario_ldap")
                    .HasMaxLength(50)
                    .IsUnicode(false);
        }
    }
}
