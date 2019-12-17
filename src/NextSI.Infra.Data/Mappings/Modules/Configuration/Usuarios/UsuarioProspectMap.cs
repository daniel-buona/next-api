using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Usuarios
{
    public class UsuarioProspectMap : IEntityTypeConfiguration<UsuarioProspect>
    {
        public void Configure(EntityTypeBuilder<UsuarioProspect> builderentity)
        {
                builderentity.HasKey(e => new { e.UsuarioId, e.ProspectId });

                builderentity.ToTable("usuario_prospect");

                builderentity.HasIndex(e => e.ProspectId)
                    .HasName("fk_usuario_prospect_prospect_idx");

                builderentity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                builderentity.Property(e => e.ProspectId)
                    .HasColumnName("prospect_id")
                    .HasColumnType("int(11)");

                builderentity.HasOne(d => d.Prospect)
                    .WithMany(p => p.UsuarioProspect)
                    .HasForeignKey(d => d.ProspectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_prospect_prospect");

                builderentity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Prospects)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_prospect_usuario");
        }
    }
}