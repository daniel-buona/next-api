using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Usuarios
{
    public class UsuarioFornecedorMap : IEntityTypeConfiguration<UsuarioFornecedor>
    {
        public void Configure(EntityTypeBuilder<UsuarioFornecedor> builder)
        {
                builder.HasKey(e => new { e.UsuarioId, e.FornecedorId });

                builder.ToTable("usuario_fornecedor");

                builder.HasIndex(e => e.FornecedorId)
                    .HasName("fk_usuario_fornecedor_fornecedor1_idx");

                builder.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.FornecedorId)
                    .HasColumnName("fornecedor_id")
                    .HasColumnType("int(11)");

                builder.HasOne(d => d.Fornecedor)
                    .WithMany(p => p.UsuarioFornecedor)
                    .HasForeignKey(d => d.FornecedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_fornecedor_fornecedor1");

                builder.HasOne(d => d.Usuario)
                    .WithMany(p => p.Fornecedores)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_fornecedor_usuario1");
        }
    }
}