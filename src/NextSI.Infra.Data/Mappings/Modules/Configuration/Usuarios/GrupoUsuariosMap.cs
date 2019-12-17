using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration
{
    public class GrupoUsuariosMap : IEntityTypeConfiguration<GrupoUsuarios >
    {
        public void Configure(EntityTypeBuilder<GrupoUsuarios > builder)
        {

            builder.ToTable("grupo_usuarios");

            builder.HasIndex(e => e.DeleteUsuarioId)
                .HasName("fk_grupo_usuario_usuario3_idx");

            builder.HasIndex(e => e.InsertUsuarioId)
                .HasName("fk_grupo_usuario_usuario1_idx");

            builder.HasIndex(e => e.UpdateUsuarioId)
                .HasName("fk_grupo_usuario_usuario2_idx");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Agenda)
                .HasColumnName("agenda")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Chamados)
                .HasColumnName("chamados")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Crm)
                .HasColumnName("crm")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

            builder.Property(e => e.DeleteUsuarioId)
                .HasColumnName("delete_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Documentos)
                .HasColumnName("documentos")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Excluido)
                .IsRequired()
                .HasColumnName("excluido")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Inovacao)
                .HasColumnName("inovacao")
                .HasColumnType("char(1)");

            builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

            builder.Property(e => e.InsertUsuarioId)
                .HasColumnName("insert_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Processos)
                .HasColumnName("processos")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Projetos)
                .HasColumnName("projetos")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.Social)
                .HasColumnName("social")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.TipoGrupoUsuario)
                .IsRequired()
                .HasColumnName("tipo_grupo_usuario")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("1");

            builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

            builder.Property(e => e.UpdateUsuarioId)
                .HasColumnName("update_usuario_id")
                .HasColumnType("int(11)");
        }
    }
}
