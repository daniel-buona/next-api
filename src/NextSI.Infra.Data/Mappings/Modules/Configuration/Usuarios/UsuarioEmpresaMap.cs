using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Usuarios
{
    public class UsuarioEmpresaMap : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> builder)
        {
            builder.HasKey(e => new { e.UsuarioId, e.EmpresaId });

            builder.ToTable("usuario_empresa");

            builder.HasIndex(e => e.EmpresaId)
                .HasName("fk_usuario_has_empresa_empresa1_idx");

            builder.HasIndex(e => e.UsuarioId)
                .HasName("fk_usuario_has_empresa_usuario1_idx");

            builder.Property(e => e.UsuarioId)
                .HasColumnName("usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.EmpresaId)
                .HasColumnName("empresa_id")
                .HasColumnType("int(11)");

            builder.HasOne(d => d.Empresa)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_has_empresa_empresa1");

            builder.HasOne(d => d.Usuario)
                .WithMany(p => p.Empresas)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_has_empresa_usuario1");
        }
    }
}