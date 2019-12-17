using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Empresas
{
    public class EmpresaMatrizMap : IEntityTypeConfiguration<EmpresaMatriz>
    {
        public void Configure(EntityTypeBuilder<EmpresaMatriz> builder)
        {
                builder.ToTable("empresa_matriz");

                builder.HasIndex(e => e.DeleteUsuarioId)
                    .HasName("fk_empresa_matriz_usuario3_idx");

                builder.HasIndex(e => e.EmpresaGrupoId)
                    .HasName("fk_empresa_matriz_empresa_grupo1_idx");

                builder.HasIndex(e => e.InsertUsuarioId)
                    .HasName("fk_empresa_matriz_usuario1_idx");

                builder.HasIndex(e => e.UpdateUsuarioId)
                    .HasName("fk_empresa_matriz_usuario2_idx");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

                builder.Property(e => e.DeleteUsuarioId)
                    .HasColumnName("delete_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.EmpresaGrupoId)
                    .HasColumnName("empresa_grupo_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Excluido)
                    .IsRequired()
                    .HasColumnName("excluido")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("N");

                builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

                builder.Property(e => e.InsertUsuarioId)
                    .HasColumnName("insert_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

                builder.Property(e => e.UpdateUsuarioId)
                    .HasColumnName("update_usuario_id")
                    .HasColumnType("int(11)");

                builder.HasOne(d => d.EmpresaGrupo)
                    .WithMany(p => p.EmpresaMatriz)
                    .HasForeignKey(d => d.EmpresaGrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_empresa_matriz_empresa_grupo1");

        }
    }
}
