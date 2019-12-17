using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration
{
    public class UsuarioGrupoUsuariosMap : IEntityTypeConfiguration<UsuarioGrupoUsuarios>
    {
        public void Configure(EntityTypeBuilder<UsuarioGrupoUsuarios> builder)
        {
            builder.HasKey(e => new { e.UsuarioId, e.GrupoUsuariosId });

            builder.ToTable("usuario_grupo_usuarios", "next");

            builder.HasIndex(e => e.GrupoUsuariosId)
                .HasName("fk_usuario_grupo_usuarios_grupo_usuarios1_idx");

            builder.HasIndex(e => e.UsuarioId)
                .HasName("fk_usuario_grupo_usuarios_usuario1_idx");

            builder.Property(e => e.UsuarioId)
                .HasColumnName("usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.GrupoUsuariosId)
                .HasColumnName("grupo_usuarios_id")
                .HasColumnType("int(11)");

            builder.HasOne(d => d.GrupoUsuarios)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.GrupoUsuariosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_grupo_usuarios_grupo_usuarios1");

            builder.HasOne(d => d.Usuario)
                .WithMany(p => p.Grupos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_grupo_usuarios_usuario1");
        }
    }
}