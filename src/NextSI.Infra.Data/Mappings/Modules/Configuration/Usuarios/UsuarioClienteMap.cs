using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Usuarios
{
    public class UsuarioClienteMap : IEntityTypeConfiguration<UsuarioCliente>
    {
        public void Configure(EntityTypeBuilder<UsuarioCliente> builder)
        {
            builder.HasKey(e => new { e.UsuarioId, e.ClienteId });

            builder.ToTable("usuario_cliente");

            builder.HasIndex(e => e.ClienteId)
                .HasName("fk_usuario_cliente_cliente1_idx");

            builder.Property(e => e.UsuarioId)
                .HasColumnName("usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ClienteId)
                .HasColumnName("cliente_id")
                .HasColumnType("int(11)");

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_cliente_cliente1");

            builder.HasOne(d => d.Usuario)
                .WithMany(p => p.Clientes)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_cliente_usuario1");
        }
    }
}